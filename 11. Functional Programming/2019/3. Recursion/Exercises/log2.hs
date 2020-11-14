main = do
    firstLine <- getLine
    let value = read firstLine :: Int
    let result = log2 value
    putStrLn (show(result))

log2 :: Int -> Int
log2 n =
    if n == 1 
    then 0
    else 1 + log2 (div n 2)