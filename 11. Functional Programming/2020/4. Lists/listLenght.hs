-- Собствена функция за намиране на дължина на списък
findLength length list =
    if null list
    then (length-1)
    else findLength (length+1) (tail list)

-- Спомагателна финцкия
listLength list = findLength 1 list 

-- Главна функция
main = do

    let list = [1,2,3]
    putStrLn(show(length list)) -- 3
    putStrLn(show(listLength list)) -- 3
