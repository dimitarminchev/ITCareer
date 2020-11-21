# Примерен изпит

## Зад. 1 Цифра като дума
Напишете програма, която продължително приема едноцифрени числа за вход и ги принтира на конзолата като дума. 

| Вход | Изход |
|------|-------|
| 0    | Zero  |
| 1    | One   |
| 2    | Two   |
| 3    | Three |
| 4    | Four  |
| 5    | Five  |
| 6    | Six   |
| 7    | Seven |
| 8    | Eight |
| 9    | Nine  |
 
При въвеждане на **End** програмата да спира изпълнението си. За целта -  възползвайте се от библиотеката System.Exit и метода, който тя предлага exitWith, като го извикате с параметър ExitSuccess. При вход на отрицателно число или число с повече от 1 цифра да се изпише **Please only enter single digit positive numbers**. 

## Пример

| Вход | Изход                                           |
|------|-------------------------------------------------|
| 5    | Five                                            |
| 9    | Nine                                            |
| 11   | Please only enter single digit positive numbers |
| End  |                                                 |

## Решение
```
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
```