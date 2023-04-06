-- Conditions Haskell Program

-- version 1: (if .. then .. else)
simpleFunction a =
    if a == 5
    then "Five :)"
    else if a == 6 
         then "Six :)"
         else "It is neither Five nor Six :("

-- version 2: (guards)
simpleFunction' a 
    | a == 5 = "Five :)"
    | a == 6 = "Six :)"
    | otherwise = "It is neither Five nor Six :(" 

-- version 3: (case)
simpleFunction'' a = case a of
    5 -> "Five :)"
    6 -> "Six :)"
    _ -> "It is neither Five nor Six :("

-- Main
main = do

    -- Execute func version 1
    putStrLn (simpleFunction 5)
    putStrLn (simpleFunction 6)
    putStrLn (simpleFunction 7)

    -- Execute func version 2
    putStrLn (simpleFunction' 5)
    putStrLn (simpleFunction' 6)
    putStrLn (simpleFunction' 7)

    -- Execute func version 3
    putStrLn (simpleFunction'' 5)
    putStrLn (simpleFunction'' 6)
    putStrLn (simpleFunction'' 7)