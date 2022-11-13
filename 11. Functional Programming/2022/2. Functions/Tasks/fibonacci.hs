-- Рекурсивна функция за намиране на числата от редицата на фицоначи
fib n =
    if n == 1 || n == 2
    then 1
    else fib(n-1) + fib(n-2)

-- Главен метод
main = do

    -- Четем ред от конзолата, превръщаме го в число, използваме рекурсиванта функция и отпечатваме резултата
    line <- getLine
    let number = read line :: Int
    putStrLn(show(fib number))
    -- Fibonacci Sequence: 0 1 1 2 3 5 8 13 21 ... f[n]
    -- f[0] = 0, f[1] = 1, ... , f[n] = f[n-2] + f[n-1] 