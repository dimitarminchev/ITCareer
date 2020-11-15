-- Рекурсивно обхождане на списък и премахване на четните елементи
removeEven nums =
    if null nums
    then []
    else if (mod (head nums) 2) /= 0
         then (head nums) : (removeEven (tail nums))
         else removeEven (tail nums)

-- Главен метод
main = do

    -- Създаваме списък
    let list = [1,2,3,4,5,6,7,8,9,10]
    let list' = removeEven [1,2,3,4,5,6,7,8,9,10]

    -- Отпечатваме списък
    putStrLn(show(list))  -- [1,2,3,4,5,6,7,8,9,10]
    putStrLn(show(list')) -- [1,3,5,7,9]