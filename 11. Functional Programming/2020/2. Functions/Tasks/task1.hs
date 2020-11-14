-- Функция за удвояване на число
doubleIt x = x * 2

-- Главна функция
main = do

    -- Четем число, удвояваме го и го отпечтваме
    line <- getLine
    let n = read line :: Int
    putStrLn(show(doubleIt n))