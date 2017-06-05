delete from tbl_kotsuhotel
where kouenkai_no in 
(SELECT
    TBL_KOUENKAI.kouenkai_no
FROM
    TBL_KOUENKAI INNER JOIN (SELECT
                                KOUENKAI_NO,
                                MAX(TIME_STAMP) TIME_STAMP_MAX
                            FROM
                                TBL_KOUENKAI
                            WHERE
                                FROM_DATE <= '20151231' AND
                                FROM_DATE <> ''
                            GROUP BY
                                KOUENKAI_NO
                            ) WK1 ON TBL_KOUENKAI.KOUENKAI_NO=WK1.KOUENKAI_NO AND TBL_KOUENKAI.TIME_STAMP=WK1.TIME_STAMP_MAX
WHERE
    TBL_KOUENKAI.FROM_DATE <= '20151231' AND
    TBL_KOUENKAI.FROM_DATE <> ''
)
