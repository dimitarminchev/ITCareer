isEven n = do
    if mod n 2 == 0
        then True
    else False

main = do
    firstLine <- getLine
    let value = read firstLine :: Int
    putStrLn(show(isEven value))