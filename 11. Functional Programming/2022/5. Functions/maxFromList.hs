-- Намиране на максимален елемент от списък
maxFromList list = foldl max (head list) list   

-- Главна функция/метод
main = do
    
    -- Създаване на списък
    let list = [1,5,10]
    let max = maxFromList [1,5,10]
    
    -- Отпечатваме резултата
    putStrLn(show(list)) -- [1,5,10]
    putStrLn(show(max)) -- 10