-- Зад. 3 Дупликиране на елементи от списък

-- Рекурсивен метод за дулиране на елементите от списъка
duplicateList list =
    if null list
    then []
    else head list : head list : duplicateList (tail list)

-- Главна функция
main = do
    -- Създане на списъци
    let list = "abc"
    let list' = [1,2,3]
    -- Отпечатване на списъци
    putStrLn(show(duplicateList list)) -- "aabbcc"
    putStrLn(show(duplicateList list')) -- [1,1,2,2,3,3]