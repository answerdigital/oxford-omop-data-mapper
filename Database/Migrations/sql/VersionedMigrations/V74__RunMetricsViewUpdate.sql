create or alter view [dbo].[run_analysis_metrics] as
with rank_provenance as (
    select
        data_source,
        substring(data_source, charindex(':', data_source) + 1, len(data_source)) as origin,
        row_number() over (partition by table_key, table_type_id order by column_name desc) as [rank]
    from dbo.provenance
),
rank_provenance_counts as (
    select
        origin,
        isnull(count(*), 0) as output_count
    from rank_provenance
    where [rank] = 1
    group by origin
),
latest_runs as (
    select
        processed_origin,
        run_id,
        datetime_utc
    from (
        select 
            substring(origin, charindex(':', origin) + 1, len(origin)) as processed_origin,
            run_id,
            datetime_utc,
            row_number() over (
                partition by substring(origin, charindex(':', origin) + 1, len(origin))
                order by datetime_utc desc
            ) as rn
        from dbo.run_analysis
    ) ranked
    where rn = 1
)
select 
    ra.run_id,
    ra.table_type,
    ra.datetime_utc,
    substring(ra.origin, charindex(':', ra.origin) + 1, len(ra.origin)) as origin,
    ra.valid_count + ra.invalid_count as source_count,
    ra.valid_count as validated_count,
    coalesce(mc.output_count, 0) as output_count
from dbo.run_analysis ra
inner join latest_runs lr 
    on ra.run_id = lr.run_id
    and substring(ra.origin, charindex(':', ra.origin) + 1, len(ra.origin)) = lr.processed_origin
left join rank_provenance_counts mc 
    on lower(replace(lr.processed_origin, ' ', '')) = lower(replace(mc.origin, ' ', ''));

go