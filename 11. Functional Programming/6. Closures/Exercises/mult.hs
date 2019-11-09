add x = (\y -> x * y)

main = do
    firstLine <- getLine
    secondLine <- getLine
    let a = read firstLine :: Int
    let b = read secondLine :: Int
    putStrLn(show(add a b))