-- Зад. 6 Факториел (списък)

-- Рекурсивен метод/функция за намиране на факториелите до зададено число
getFacList list currValue n i =
    if(n < i)
    then []
    else currValue : getFacList list (currValue * i) n (i+1)

-- Помощен метод/функция
facList n = getFacList [] 1 n 1

-- Главен метод/функция
main = do
    -- Четем ред от конзолата и го обръщаме в int
    input <- getLine
    let value = read input :: Int
    -- Отпечаваме списъка
    putStrLn(show((facList value) :: [Int]))

    -- Input: 19
    -- Output: [1,1,2,6,24,120,720,5040,40320,362880]