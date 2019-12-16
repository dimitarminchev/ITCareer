/* Problem 1. Минимално зареждане на депозит */
SELECT deposit_group, magic_wand_creator, MIN(deposit_charge) AS `min_deposit_charge`
FROM gringotts.wizzard_deposits
GROUP BY deposit_group
ORDER BY magic_wand_creator ASC, deposit_group DESC;
