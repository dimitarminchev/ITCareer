-- Функция за проверка на честно число
isEven n = do
    if mod n 2 == 0
    then True
    else False

-- Главна функция
main = do

    -- Четем число, проверяваме и отпечтваме резултата
    line <- getLine
    let n = read line :: Int
    putStrLn(show(isEven n))