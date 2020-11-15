-- Зад. 1 Умножение на числа
add x = (\y -> x * y)

-- Главен метод/функция
main = do

    -- Четем два реда от конзолата
    firstLine <- getLine -- 5
    secondLine <- getLine -- 10

    -- Обръщаме ги в цели числа
    let a = read firstLine :: Int
    let b = read secondLine :: Int

    -- Отпечатваме резултата
    putStrLn(show(add a b)) -- 50