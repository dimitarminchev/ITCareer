-- Функция за намиране на сължина на списък
listLength [] = 0
listLength list = findLength 1 list
findLength length list = 
    if null list
    then (length - 1)
    else findLength (length + 1) (tail list)

-- Главна функция
main = do
    putStrLn(show(listLength [123,456])) -- 2
    putStrLn(show(listLength [1])) -- 1
    putStrLn(show(listLength [])) -- 0
    putStrLn(show(listLength "Hello, world!")) -- 13
