import System.Exit;

-- Метод/функция за отпечатване на числата от 0 до 9
printNumber number
    | number == 0 = do
        putStrLn "Zero"
    | number == 1 = do
        putStrLn "One"
    | number == 2 = do
        putStrLn "Two"
    | number == 3 = do
        putStrLn "Three"
    | number == 4 = do
        putStrLn "Four"
    | number == 5 = do
        putStrLn "Five"
    | number == 6 = do
        putStrLn "Six"
    | number == 7 = do
        putStrLn "Seven"
    | number == 8 = do
        putStrLn "Eight"
    | number == 9 = do
        putStrLn "Nine"
    | otherwise = do
        putStrLn "Please only enter single digit positive numbers"

-- Рекурсивен метод/функция за обработка на входните данни
numberToWord = do
    -- Четем ред от конзолата
    line <- getLine
    -- Проверка за достигнат край
    if line == "End"
    then exitWith ExitSuccess
    else do
        -- Превръщаме реда в число
        let number = read line :: Integer
        -- Извикваме метод
        printNumber number
        -- Рекурсия
        numberToWord

-- Главен метод/функция
main = do
    -- Извикване на метод
    numberToWord