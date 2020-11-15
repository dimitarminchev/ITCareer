-- Зад. 2 Дължина на списък

-- Рекурсивна функция за намиране на дължина на списък
listLenghtLoop list counter =
    if null list
    then counter
    else listLenghtLoop (tail list) (counter + 1)

-- Помощна функция
listLenght list = listLenghtLoop list 0

-- Главна функция
main = do
    -- Създаваме списък и го отпечатваме
    let list = [123,456]
    let list' = "Hello, world!"
    putStrLn (show(listLenght list)) -- 2
    putStrLn (show(listLenght list')) -- 13
