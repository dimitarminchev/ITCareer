-- Функция за създаване на списък
createList start end = createListLoop [] start end

-- Рекурсивна функция за създаване на списък
createListLoop list start end =
    if start > end
    then list
    else createListLoop (list ++ [start]) (start + 1) end

-- Главна функция
main = do
    let numbers = createList 1 10 
    putStrLn(show(numbers)) -- [1,2,3,4,5,6,7,8,9,10]