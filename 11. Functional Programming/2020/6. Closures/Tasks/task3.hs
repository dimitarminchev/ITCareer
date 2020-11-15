-- Зад. 3 Подаване на функция като аргумент на функция

-- Сложна съставна функция
compose x = (\func -> func x)

-- Функция добавяще единица
add1 x = x + 1

-- Функция премахваща единица
remove1 x = x - 1

-- Главна фубкция/метод
main = do

    -- Четем два реда от конзолата
    number <- getLine
    func <- getLine
    
    -- Обръщаме втория ред  в цяло число
    let value = read number :: Int

    -- Изпълняваме 
    if func == "add1"
    then putStrLn(show(compose value add1))
    else putStrLn (show(compose value remove1))

    -- Input: 5 add1
    -- Output: 6

    -- Input: 5 remove1
    -- Output: 4 