main = do
    firstLine <- getLine
    secondLine <- getLine
    let a = read firstLine :: Int
    let b = read secondLine :: Int
    let result = a * b
    putStrLn (show(result))