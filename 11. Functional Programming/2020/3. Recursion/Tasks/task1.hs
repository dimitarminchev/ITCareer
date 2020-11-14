-- Логаритъм втори от n
log2 n = 
    if n == 1
    then 0
    else 1 + log2 (div n 2)

-- Главна функция
main = do

    -- Четем входни данни, обработваме ги и звеждаме резултата
    line <- getLine
    let n = read line :: Int
    putStrLn(show(log2 n))