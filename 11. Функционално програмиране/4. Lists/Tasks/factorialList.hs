-- Зад. 6 Списък с Факториел числа

-- Рекурсивна функция за намиране на факториелите до зададено число
getFacList list currValue n i =
    if(n < i)
    then []
    else currValue : getFacList list (currValue * i) n (i+1)

-- Помощна функция
facList n = getFacList [] 1 n 1

-- Главна функция
main = do
    putStrLn(show((facList 19) :: [Int]))
    -- [1,1,2,6,24,120,720,5040,40320,362880,3628800,39916800,479001600,6227020800,87178291200,1307674368000,20922789888000,355687428096000,6402373705728000]