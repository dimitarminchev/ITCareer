compose x = (\func -> func x)

add1 x = x + 1
mult2 x = 2*x

main = do
    firstLine <- getLine
    let a = read firstLine :: Int
    putStrLn(show(compose a add1))
    putStrLn(show(compose a mult2))