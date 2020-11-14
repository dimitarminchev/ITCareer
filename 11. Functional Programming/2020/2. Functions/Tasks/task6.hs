-- Рекурсивна функция за намиране на числата от редицата на фицоначи
fib n =
    if n == 1 || n == 2
    then 1
    else fib(n-1) + fib(n-2)

-- Главен метод
main = do

    -- Четем ред от конзолата, превръщаме го в число, използваме рекурсиванта функция и отпечатваме резултата
    firstLine <- getLine
    let value = read firstLine :: Int
    putStrLn(show(fib value))