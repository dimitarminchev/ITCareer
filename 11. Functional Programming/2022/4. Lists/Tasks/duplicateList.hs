-- Функция за дублиране на елементите на списък
duplicateList [] = []
duplicateList (x:xs) = x:x:duplicateList xs

-- Главна функция
main = do
    putStrLn(show(duplicateList "abc")) -- aabbcc
    putStrLn(show(duplicateList [1,2,3])) -- 112233
    putStrLn(show(duplicateList [1])) -- 11