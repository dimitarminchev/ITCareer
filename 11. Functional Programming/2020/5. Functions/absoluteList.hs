-- Прилагане на операция abs върху всички елементи от списък
absoluteList list = map abs list

-- Главен метод
main = do

     -- Създаваме списък
    let list = [1,2,3,-4,-5]
    let list' = absoluteList [1,2,3,-4,-5]

    -- Отпечатваме променения списък
    putStrLn(show(list)) -- [1,2,3,-4,-5]
    putStrLn(show(list')) -- [1,2,3,4,5]