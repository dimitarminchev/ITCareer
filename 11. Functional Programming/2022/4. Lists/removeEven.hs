-- Рекурсивна функция за премахване на четните елементи
removeEven nums =
    if null nums
    then []
    else 
        if (mod (head nums) 2 ) /= 0
        then (head nums) : (removeEven (tail nums))
        else                removeEven (tail nums)

-- Главна функция
main = do
    let nums = [1,2,3,4,5,6,7,8,9,10]
    putStrLn(show(removeEven nums)) -- [1,3,5,7,9]