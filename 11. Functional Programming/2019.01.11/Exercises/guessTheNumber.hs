main = do
    firstLine <- getLine
    let numberToGuess = read firstLine :: Int
    guessTheNumber numberToGuess

guessTheNumber n = do
    line <- getLine
    let guessedNumber = read line :: Int
    if guessedNumber /= n
        then do
        if guessedNumber < n
            then do
            putStrLn "Too low!";
            guessTheNumber n
        else do
            putStrLn "Too high!";
            guessTheNumber n
    else
        putStrLn "You win!"
