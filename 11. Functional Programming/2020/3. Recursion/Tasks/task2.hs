-- Рекурсивна функция за намиране на Факториел (Опашкова рекурсия)
findFactorial n initialValue index = 
    if index > n
    then initialValue
    else findFactorial n (initialValue*index) (index+1)

-- Помощна функция за намиране на Факториел
factorial n = findFactorial n 1 1

-- Главна функция
main = do

    -- Четем входни данни, обработваме ги и звеждаме резултата
    line <- getLine
    let n = read line :: Int
    putStrLn(show(factorial n))