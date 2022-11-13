-- Рекурсивно оптимизиране функция за намиране на фибоначи
findFibonacci n initialValue prevValue index =
    if (index > n)
    then initialValue
    else findFibonacci n (initialValue + prevValue) initialValue (index + 1)

-- Функция за фибоначи
fibonacci n = findFibonacci n 0 1 1

-- Главна функция
main = do
    putStrLn(show(fibonacci 10)) -- Result: 55
    putStrLn(show(fibonacci 21)) -- Result: 10946