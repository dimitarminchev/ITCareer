findFactorial n result index =
    if index > n
    then result
    else findFactorial n (result * index) (index + 1)

factorial n = findFactorial n 1 1

main = do
    input <- getLine
    let n = read input :: Integer
    let result = factorial n
    putStrLn (show(result))