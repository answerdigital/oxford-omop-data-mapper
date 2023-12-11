if object_id('cds_line01') is not null begin drop table cds_line01; end
if object_id ('insert_cds_line01') is not null begin drop procedure insert_cds_line01 end
if type_id ('cds_line01_row') is not null begin drop type cds_line01_row end;