fib n =
    if n == 1 || n == 2
    then 1
    else fib(n-1) + fib(n-2)

main = do
    firstLine <- getLine
    let value = read firstLine :: Int
    putStrLn(show(fib value))