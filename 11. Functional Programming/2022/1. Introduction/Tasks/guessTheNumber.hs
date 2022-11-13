-- Задача 5

-- Главна функция
main = do
    line <- getLine
    let num = read line :: Integer
    guessingGame num

-- Функция за познаване на число
guessingGame num = do
    line <- getLine
    let guessedNum = read line :: Integer
    if guessedNum > num
    then do 
        putStrLn "Too high!"
        guessingGame num
    else if guessedNum < num
    then do
        putStrLn "Too low!"
        guessingGame num
    else putStrLn "You win!"