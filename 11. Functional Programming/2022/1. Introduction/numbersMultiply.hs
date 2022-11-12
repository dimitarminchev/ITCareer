main = do

    -- input 2 lines of string
    putStrLn ("Enter first number: ")
    firstLine <- getLine
    putStrLn ("Enter second number: ")
    secondLine <- getLine

    -- convert string to integer
    let firstNum = read firstLine :: Integer
    let secondNum = read secondLine :: Integer

    -- output the multiplication of the 2 ingeres
    putStrLn ("Multiplication of the numbers is: ")
    putStrLn (show (firstNum * secondNum))