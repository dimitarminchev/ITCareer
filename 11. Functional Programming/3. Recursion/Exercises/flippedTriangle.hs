printTriangle n = do
    if n > 0
    then do
        let row = printRow n
        putStrLn row
        printTriangle (n-1)
    else return()

printRow n =
    if n == 0
    then ""
    else "*" ++ printRow (n-1)

main :: IO()
main = do
    input <- getLine
    let n = read input :: Int
    printTriangle n