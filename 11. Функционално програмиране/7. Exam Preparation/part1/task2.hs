-- Импортиране на библиотеката Data.Char заради функцията digitToInt
import Data.Char

-- Функция за сумиране на списък от числа
sumList list = foldr (+) 0 list

-- Функция за конвертиране на списък към цели числа
toNumber list = map (digitToInt) list

-- Главна функция
main = do

    -- Въвеждаме от стандартният вход
    line <- getLine

    -- Намиране на средното аритметично
    let average = div (sumList (toNumber line)) (length line)

    -- Отпечаване на стандартният изход
    putStrLn (show(average))