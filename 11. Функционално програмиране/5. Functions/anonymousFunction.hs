-- Изпозлване на анономни функции
plus3 x y z = x + y + z
plus3' = (\ x y z -> x + y + z)

-- Главен метод
main = do

    -- Тестваме 
    putStrLn(show(plus3 1 2 3)) -- 6
    putStrLn(show(plus3' 1 2 3)) -- 6