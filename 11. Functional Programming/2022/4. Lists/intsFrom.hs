
-- Рекурсивна функция за създаване на списък до n
intsFrom n = n : (intsFrom (n+1))

-- Функция за създаване на безкраен списък
ints = intsFrom 1

-- Главна функция
main = do
    let numbers = take 10 ints 
    putStrLn(show(numbers)) -- [1,2,3,4,5,6,7,8,9,10]
