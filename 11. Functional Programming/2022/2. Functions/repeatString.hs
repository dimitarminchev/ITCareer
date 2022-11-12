-- Рекурсивен мето за генериане на повторение в низ
repeatString str n =
    if n == 0
    then "" -- Дъно на рекурсията
    else str ++ (repeatString str (n-1)) -- Рекурсия

-- Главен метод
main = do
   
    -- Повтаряме низа "Hello" 5 на брой пъти 
    putStrLn(repeatString "Hello" 5)