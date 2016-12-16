select distinct 
 ms_event.event_no,
 ms_event.event_name,
 ms_event.event_date,
 wk_file.file_seq,
 wk_file.file_name_jpn,
 wk_file.file_name 
 from ms_event join 
 (select distinct 
 	tbl_endreport.*,
 	tbl_file.file_kbn,
 	tbl_file.file_seq,
 	tbl_file.file_name_jpn,
 	tbl_file.file_name 
 	from tbl_endreport join tbl_file 
 	on tbl_endreport.event_no=tbl_file.event_no 
 	where tbl_file.file_kbn='04'
 ) as wk_file 
on ms_event.event_no=wk_file.event_no 
where 
ms_event.event_date between '20160701' and '20161031' 
order by ms_event.event_no
