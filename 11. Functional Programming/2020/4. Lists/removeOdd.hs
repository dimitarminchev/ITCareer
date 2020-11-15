-- Рекурсивно обхождане на списък и премахване на нечетните елементи
removeOdd nums =
    if null nums
    then []
    else if (mod (head nums) 2) == 0
         then (head nums) : (removeOdd (tail nums))
         else removeOdd (tail nums)

-- Главен метод
main = do

    -- Създаваме списък
    let list = [1,2,3,4,5,6,7,8,9,10]
    let list' = removeOdd [1,2,3,4,5,6,7,8,9,10]

    -- Отпечатваме списък
    putStrLn(show(list))  -- [1,2,3,4,5,6,7,8,9,10]
    putStrLn(show(list')) -- [2,4,6,8,10]