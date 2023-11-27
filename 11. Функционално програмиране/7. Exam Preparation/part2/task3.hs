-- Импортираме библиотека Data.Char заради функцията digitToInt
import Data.Char

-- Функция за филтриране само на цифри
onlyDigits = (filter isDigit)

-- Функция за конвертиране на списък към цели числа
toNumber x = map (digitToInt) x

-- Функция за сумиране на списък
sumNumbers x = foldl (+) 0 x

-- Глвна функция
main = do

    -- Въвеждаме от стандартният вход 
    line <- getLine

    -- Получаване на целочислен списък 
    let numbers = toNumber (onlyDigits line)
  
    -- Отпечаване на стандартният изход
    putStrLn( show(sumNumbers numbers) )