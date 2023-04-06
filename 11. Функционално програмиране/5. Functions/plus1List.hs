-- Прилагане на операция +1 върху всички елементи от списък
plus1list list = map (1 + ) list

-- Главен метод
main = do

    -- Създаваме списък
    let list = [1,2,3,4,5]
    let list' = plus1list [1,2,3,4,5]

    -- Отпечатваме променения списък
    putStrLn(show(list)) -- [1,2,3,4,5]
    putStrLn(show(list')) -- [2,3,4,5,6]