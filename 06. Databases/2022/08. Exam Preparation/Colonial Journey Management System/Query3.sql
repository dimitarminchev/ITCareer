UPDATE `journeys`
SET `journeys`.`purpose` = 'Military'
WHERE MOD(`journeys`.`id`, 7) = 0;

UPDATE `journeys`
SET `journeys`.`purpose`='Educational'
WHERE MOD(`journeys`.`id`, 5) = 0;

UPDATE `journeys`
SET `journeys`.`purpose` = 'Technical'
WHERE MOD(`journeys`.`id`, 3) = 0;

UPDATE `journeys`
SET `journeys`.`purpose` = 'Medical'
WHERE MOD(`journeys`.`id`, 2) = 0;