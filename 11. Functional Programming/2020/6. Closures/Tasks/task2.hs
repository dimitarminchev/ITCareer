-- Зад. 2 Най-голямо от три числа
maxOfThree a b = (\c -> max (max a b) c)

-- Главен метод/функция
main = do

    -- Четем три реда от конзолата
    firstLine <-  getLine -- 5
    secondLine <- getLine -- 10
    thirdLine <- getLine  -- 20

    -- Обръщаме ги в цели числа
    let a = read firstLine :: Int
    let b = read secondLine :: Int
    let c = read thirdLine :: Int

    -- Отпечатваме резултата
    putStrLn(show(maxOfThree a b c)) -- 20