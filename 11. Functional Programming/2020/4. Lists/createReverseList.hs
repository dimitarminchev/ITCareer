-- Рекурсивна функция за създаване на обурнат списък
createReverseListLoop list start end =
    if start > end
    then list
    else createReverseListLoop (start : list) (start+1) end
    
-- Помощна функция за създаване на обърнат списък
createReverseList start end = createReverseListLoop [] start end

-- Главна функция
main = do
    -- Създаваме списък и го отпечатваме
    putStrLn (show(createReverseList 1 20)) -- [20,19,18 .. 1]
