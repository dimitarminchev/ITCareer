-- Функция която връща log2 на 1
log2 1 = 0

-- Рекурсивна функция за намиране на log2
log2 n = 1 + log2 (n `div` 2)

-- Главна функция
main = do
    putStrLn(show(log2 15)) -- Result: 3
    putStrLn(show(log2 10)) -- Result: 3
    putStrLn(show(log2 10000)) -- Result: 13