-- Зад. 4 Премахване на всеки n-ти елемент

-- Рекурсивна функция за изтриване на N-ти елемент от списъка
deleteEveryNthElement :: [Int] -> Int -> [Int]
deleteEveryNthElement list n =
    if length list < n
    then list
    else (take (n - 1) list) ++ (deleteEveryNthElement (drop n list) n)

-- Главна функция
main = do
    putStrLn(show(deleteEveryNthElement [1,2,3,4,5,6,7,8,9] 3)) -- [1,2,4,5,7,8]
    putStrLn(show((deleteEveryNthElement [1,2,3,4,5,6,7,8,9] 1) :: [Int])) -- []
    putStrLn(show(deleteEveryNthElement [1,2,3] 3)) -- [1,2]
