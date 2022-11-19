-- Извършване на операции върху всички елементи на списъка
substactList list = foldl (-) 0 list
substactList' list = foldr (-) 0 list

-- Главен метод/функция
main = do

    -- Създаване на списъци
    let list = substactList [1,2,3,4,5]
    let list' = substactList' [1,2,3,4,5]

    -- Отпечатване на резултата
    putStrLn(show(list)) -- -15
    putStrLn (show(list')) -- 3