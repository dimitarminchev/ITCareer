import System.Exit

main = do
    numberAsWord

numberAsWord = do
    input <- getLine
    if input /= "End" then do
        let n = read input :: Int
        putStrLn (printN n)
        numberAsWord
    else exitWith ExitSuccess

printN n
    | n == 0 = "Zero"
    | n == 1 = "One"
    | n == 2 = "Two"
    | n == 3 = "Three"
    | n == 4 = "Four"
    | n == 5 = "Five"
    | n == 6 = "Six"
    | n == 7 = "Seven"
    | n == 8 = "Eight"
    | n == 9 = "Nine"
    | otherwise = "Please only enter single digit positive numbers"
