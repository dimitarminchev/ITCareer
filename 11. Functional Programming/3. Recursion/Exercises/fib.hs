findFibonacci n value prevValue index =
    if index > n
    then value
    else findFibonacci n (value + prevValue) value (index + 1)

fibonacci n = findFibonacci n 1 0 2

main = do
    input <- getLine
    let n = read input :: Integer
    let result = fibonacci n
    putStrLn(show result)