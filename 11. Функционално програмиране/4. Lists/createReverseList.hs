-- Функция за създаване на обърнат списък
createReverseList start end = createReverseListLoop [] start end

-- Рекурсивна функция за създаване на обърнат списък
createReverseListLoop list start end =
    if start > end
    then list
    else createReverseListLoop (start : list) (start + 1) end

-- Главна функция
main = do
    let numbers = createReverseList 1 10 
    putStrLn(show(numbers)) -- [10,9,8,7,6,5,4,3,2,1]