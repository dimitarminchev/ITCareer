-- Плюс Пет
plusFive n =
    if n < 0
    then (-n) + 5
    else n + 5

plusFive' n = (abs n) + 5

-- Главна функция
main = do

    -- Тест 1
    putStrLn (show(plusFive (-2)))
    -- Result: 7
    putStrLn (show(plusFive 2)) 
    -- Result: 7   

    -- Тест 2
    putStrLn (show(plusFive (-4)))
    -- Result: 9
    putStrLn (show(plusFive 4)) 
    -- Result: 9   