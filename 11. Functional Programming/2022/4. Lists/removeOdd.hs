-- Рекурсивна функция за премахване на нечетните елементи
removeOdd nums =
    if null nums
    then []
    else 
        if (mod (head nums) 2 ) == 0
        then (head nums) : (removeOdd (tail nums))
        else                removeOdd (tail nums)

-- Главна функция
main = do
    let nums = [1,2,3,4,5,6,7,8,9,10]
    putStrLn(show(removeOdd nums)) -- [2,4,6,8,10]