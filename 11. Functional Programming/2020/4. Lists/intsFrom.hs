-- Рекурсивна функция до безкрайност
intsFrom n = n : (intsFrom (n+1))

-- Помощна функция
ints = intsFrom 1

-- Главна функция
main = do
    -- Пример да вземем 10 елемента
    putStrLn(show(take 10 ints))