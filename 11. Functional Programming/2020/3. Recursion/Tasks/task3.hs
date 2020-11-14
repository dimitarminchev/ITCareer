-- Рекурсивна функция за намиране на Фибоначи (Опашкова рекурсия)

findFibonacci n initialValue prevValue index = 
    if index >= n
    then initialValue
    else findFibonacci n (initialValue + prevValue) (initialValue) (index+1)

-- Помощна функция за намиране на Фибоначи
fibonacii n = findFibonacci n 1 0 1

-- Главна функция
main = do

    -- Четем входни данни, обработваме ги и звеждаме резултата
    line <- getLine
    let n = read line :: Int
    putStrLn(show(fibonacii n))