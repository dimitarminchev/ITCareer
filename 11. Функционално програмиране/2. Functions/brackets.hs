-- Използване на скоби
main = do

    -- Тест 1
    let a = (5 + 2) * (3 - 4)
    putStrLn (show(a)) 
    -- Rezult = -7 

    -- Тест 2
    let b = max (5 + 2) (sqrt 17)
    putStrLn (show(b)) 
    -- Result = 7.0

    -- Тест 3
    let c = max 5 (-5) 
    putStrLn (show(c))
    -- Result = 5