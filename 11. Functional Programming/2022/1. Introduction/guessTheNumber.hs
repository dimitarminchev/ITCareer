main = do
    -- input 1 line of string
    putStrLn("Enter number to guess:")
    line <- getLine
    
    -- convert string to integer
    let num = read line :: Integer

    -- execute guessingGame
    guessingGame num

guessingGame num = do

    -- input 1 line of string
    putStrLn("Enter your proposal:")
    line <- getLine

    -- convert string to integer
    let guessedNum = read line :: Integer

    -- check conditions
    if guessedNum > num
    then do 
        putStrLn "The number is too high!"
        guessingGame num
    else if guessedNum < num
    then do
        putStrLn "The number is too low!"
        guessingGame num
    else putStrLn "You win the game!"