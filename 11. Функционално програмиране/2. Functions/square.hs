-- Функция с една променлива
square x = x * x

-- Главна фунцкия
main = do

    -- Тест
    let a = square 5
    putStrLn (show(a))
    -- result = 25