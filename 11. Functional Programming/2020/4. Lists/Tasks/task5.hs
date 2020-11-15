-- Зад. 5 Фибоначи (списък)

-- Рекурсивен метод/функция за намиране на числата от редицата на Фибоначи
getFibList list currValue prevValue n i =
    if(n < i)
    then []
    else currValue : getFibList list (currValue + prevValue) currValue n (i+1)

-- Помощен метод/функция
fibList n = getFibList [] 1 0 n 1

-- Главен метод/функция
main = do
    -- Четем ред от конзолата и го обръщаме в int
    input <- getLine
    let value = read input :: Int
    -- Отпечатваме списък
    putStrLn(show((fibList value) :: [Int]))

    -- Input: 15
    -- Output: [1,1,2,3,5,8,13,21,34,55,89,144,233,377,610]