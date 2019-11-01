-- 2. Functions: repeatString
repeatString str n = 
    if n == 0
    then ""
    else str ++ (repeatString str (n-1))

main = do
    putStrLn (repeatString "Haskell " 42)
    -- Result = Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell Haskell