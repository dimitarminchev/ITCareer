-- Импортиране на библиотеката Data.Char заради функцията digitToInt
import Data.Char

-- Функция за намиране на минималното число в списък
minFromList list = foldl min (head list) list

-- Функция за конвертиране на списък към цели числа
toNumber list = map (digitToInt) list

-- Главна функция
main = do

    -- Въвеждаме от стандартният вход
    line <- getLine -- 6798154

    -- Отпечатваме на стандартният изход
    putStrLn(show(minFromList(toNumber line))) -- 1