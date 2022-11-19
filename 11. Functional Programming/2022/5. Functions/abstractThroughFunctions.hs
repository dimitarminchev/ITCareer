-- Абстрация посредством изпозлване на метод/функция
abstractFunc a b func = func a b

-- Различни метод/функция
multiplicationFunc a b  = (a * b)
sumFunc a b = (a + b)
substractFunc a b = (a - b)

-- Главен метод/функция
main = do
    
    -- Тестваме различни функции
    putStrLn(show(abstractFunc 10 10 multiplicationFunc)) -- 100
    putStrLn(show(abstractFunc 10 10 sumFunc)) -- 20
    putStrLn(show(abstractFunc 10 10 substractFunc)) -- 0