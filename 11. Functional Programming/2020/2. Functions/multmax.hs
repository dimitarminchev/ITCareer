-- Функция с повече от една променлива
multMax a b x = (max a b) * x

-- Главна фунцкия
main = do

    -- Тест
    let mm = multMax 1 2 3
    putStrLn (show(mm)) 
    -- result = 6