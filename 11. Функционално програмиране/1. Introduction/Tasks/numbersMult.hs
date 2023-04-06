-- Задача 2.

-- Функция за произведението на две чсла
numbersMult = do
    -- Въвеждане на a и b
    line1 <- getLine
    line2 <- getLine

    -- Намиране на произведение
    let a = read line1 :: Int
    let b = read line2 :: Int
    let c = a * b

    -- Отпечатваме произведението
    putStrLn (show(c))

-- Главна функция
main = do

    -- Изпълнение на фунцкия
   numbersMult
