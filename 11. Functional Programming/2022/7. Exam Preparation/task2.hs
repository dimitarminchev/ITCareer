-- Импортиране на библиотека
import Data.Char

-- Функция за сумиране на списък от числа
sumList list = foldr (+) 0 list

-- Функция за конвертиране на текст в число
toNumber list = map (digitToInt) list

-- Главна функция
main = do

    -- Четем ред от стандартния вход
    line <- getLine

    -- Намиране на средното аритметично
    let average = div (sumList (toNumber line)) (length line)

    -- Отпечаване на стандартният изход сртедното аритметично
    putStrLn (show(average))