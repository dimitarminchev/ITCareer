-- Рекурсивно оптимизиране функция за намиране на факториел
findFactorial n initialValue index =
    if (index > n)
    then initialValue
    else findFactorial n (initialValue * index) (index + 1)

-- Функция за факториел
factoriel n = findFactorial n 1 1

-- Главна функция
main = do
    putStrLn(show(factoriel 5)) -- Result: 120
    putStrLn(show(factoriel 10)) -- Result: 3628800