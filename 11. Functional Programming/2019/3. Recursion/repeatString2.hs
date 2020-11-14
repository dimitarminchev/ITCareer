-- 3. Recursion

repeatStringLoop string result n = 
    if n == 0
    then result
    else repeatStringLoop string (result ++ string) (n - 1)

repeatString string n = repeatStringLoop string string n

main = do
    putStrLn (repeatString "Haskell " 3) -- Haskell Haskell Haskell