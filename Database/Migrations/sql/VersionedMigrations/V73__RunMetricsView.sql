create or alter view [dbo].[run_analysis_metrics] as
with magic as (
    select
        data_source,
        substring(data_source, charindex(':', data_source) + 1, len(data_source)) as origin,
        row_number() over (partition by table_key, table_type_id order by column_name desc) as [rank]
    from dbo.provenance
),
magic_counts as (
    select
        origin,
        isnull(count(*), 0) as output_count
    from magic
    where [rank] = 1
    group by origin
),
latest_run as (
    select top 1
        run_id
    from dbo.run_analysis
    order by datetime_utc desc
)
select 
    ra.run_id,
    ra.table_type,
    ra.datetime_utc,
    substring(ra.origin, charindex(':', ra.origin) + 1, len(ra.origin)) as origin,
    ra.valid_count + ra.invalid_count as source_count,
    ra.valid_count as validated_count,
    case 
        when mc.output_count is null then 0
        else mc.output_count
    end as output_count
from dbo.run_analysis ra
inner join latest_run lr on ra.run_id = lr.run_id
left join magic_counts mc 
    on lower(replace(substring(ra.origin, charindex(':', ra.origin) + 1, len(ra.origin)), ' ', '')) = lower(replace(mc.origin, ' ', ''));


go
