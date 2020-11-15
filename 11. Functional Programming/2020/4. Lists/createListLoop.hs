-- Помощна функция за създаване на списък
createList start end = createListLoop [] start end

-- Рекурсивна функция за създавне на списък
createListLoop list start end =
    if start > end
    then list
    else createListLoop (list ++ [start]) (start + 1) end

-- Главна функция
main = do
    -- Създаваме списък и го отпечатваме
    putStrLn (show(createList 1 20)) -- [1,2,3 ... 20]

