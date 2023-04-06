listLength [] = 0
listLength list = findLength 1 list

-- Рекурсивна функция за намиране на дължината на списък
findLength length list = 
    if null list
    then (length - 1)
    else findLength (length + 1) (tail list)

-- Главна функция
main = do
    let list = [2,3,5,7,1,9,4]
    putStrLn(show(length list)) -- Result: 7
    putStrLn(show(listLength list)) -- Result: 7
