main = do
    firstName <- getLine
    lastName <- getLine
    let name = firstName ++ " " ++ lastName
    putStrLn (name)