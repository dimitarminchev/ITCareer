-- Зад. 5 Списък с числата от редицата на Фибоначи

-- Рекурсивна функция за намиране на числата от редицата на Фибоначи
getFibList list currValue prevValue n i =
    if(n < i)
    then []
    else currValue : getFibList list (currValue + prevValue) currValue n (i+1)

-- Помощна функция
fibList n = getFibList [] 1 0 n 1

-- Главна функция
main = do
    putStrLn(show((fibList 15) :: [Int]))
    -- [1,1,2,3,5,8,13,21,34,55,89,144,233,377,610]