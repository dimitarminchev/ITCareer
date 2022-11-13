-- Задача 3.

-- Функция за намиране на лице на кръг
areaOfCircle = do
    -- Въвеждане на r
    line <- getLine

    -- Намиране на лице на кръга
    let r = read line :: Float
    let s = pi * r * r

    -- Отпечатваме лице на круг
    putStrLn (show(s))

-- Главна функция
main = do

    -- Изпълнение на фунцкия
   areaOfCircle
