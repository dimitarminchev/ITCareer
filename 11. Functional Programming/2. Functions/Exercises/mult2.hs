mult2 value = 2 * value

main = do
    firstLine <- getLine
    let value = read firstLine :: Int
    putStrLn (show(mult2 value))