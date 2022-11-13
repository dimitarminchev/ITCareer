-- Инрементиране
add1 n = n + 1

-- Декремнтиране
remove1 n = n - 1

-- Композитна
compose f n = f n

-- Главна функция
main = do

    -- Четем две числа, извършваме желаните операции и отпечтваме резултата
    func <- getLine
    number <- getLine
    let value = read number :: Int
    if func == "add1"
    then putStrLn(show(compose add1 value))
    else putStrLn (show(compose remove1 value))
