-- Рекурсивна функция за умножение на елементите на списък
doubleList list = 
    if null list
    then []
    else (2 * (head list) : (doubleList (tail list)))

-- Главна функция
main = do
    let nums = doubleList [1,2,3,4,5] 
    putStrLn(show(nums)) -- [2,4,6,8,10]