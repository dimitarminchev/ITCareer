use `geography`;

select `country_name`,`population`
from `countries`
where `continent_code` = "EU"
order by `population` desc
limit 30;