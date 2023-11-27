-- Импортиране на библиотека System.Exit заради функцият exitWith
import System.Exit

-- Функция за отпечатване на едноцифрено число като текст
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

-- Рекурсивна функция за конвертиране на едноцифрено число в текст
numberToWord = do

    -- Четем ред от конзолата
    line <- getLine

    -- Проверка дали сме получили команда End
    if line == "End" 
    then exitWith ExitSuccess
    else do

        -- Парсване на реда в цяло число
        let number = read line :: Integer

        -- Стартираме печатащата функция
        printNumber number

        -- Рекурсивно извикваме конвертиращата функция
        numberToWord

-- Главна функция
main = do
    
    -- Извиква и изпълнява рекурсивната конвертиращата функция
    numberToWord