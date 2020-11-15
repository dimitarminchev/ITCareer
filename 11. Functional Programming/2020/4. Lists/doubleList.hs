-- Рекурсивно обхождане на списък и умонжаване на всяка стойност по 2
doubleList list =
    if null list
    then []
    else (2 * (head list) : (doubleList (tail list)))

-- Главна функция
main = do

    -- Създаваме списък
    let list = [1,2,3,4,5]
    let list' = doubleList [1,2,3,4,5] 

    -- Отпечатваме списък
    putStrLn(show(list))  -- [1,2,3,4,5]
    putStrLn(show(list')) -- [2,4,6,8,10]