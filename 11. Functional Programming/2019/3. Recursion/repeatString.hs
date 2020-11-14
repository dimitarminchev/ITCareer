-- 3. Recursion

repeatString str n = 
    if n == 0
    then ""
    else str ++ (repeatString str (n-1))

main = do
    putStrLn (repeatString "Haskell " 3) -- Haskell Haskell Haskell