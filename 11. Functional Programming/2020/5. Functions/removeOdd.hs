-- Използване на филтър върху списък
isEven x = x `mod` 2 == 0
removeOdd = filter isEven

-- Главен метод/функция
main = do

    -- Създаваме списък
    let list = [1,2,3,4,5,6,7,8,9,10]
    let list' = removeOdd [1,2,3,4,5,6,7,8,9,10]

    -- Отпечатваме промяната
    putStrLn(show(list)) -- [1,2,3,4,5,6,7,8,9,10]
    putStrLn(show(list')) -- [2,4,6,8,10]