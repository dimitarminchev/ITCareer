-- Зад. 1 Обръщане на списък

-- Рекурсивна функция за създаване на обурнат списък
createReverseListLoop list start end =
    if start > end
    then list
    else createReverseListLoop (start : list) (start+1) end
    
-- Помощна функция за създаване на обърнат списък
createReverseList list = createReverseListLoop [] 1 (length list)

-- Главна функция
main = do
    -- Създаваме списък и го отпечатваме
    let list = [1,2,3,4,5]
    putStrLn (show(createReverseList list)) -- [5,4,3,2,1]
