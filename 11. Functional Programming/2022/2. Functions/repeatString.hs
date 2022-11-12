-- Рекурсивен мето за генериане на повторение в низ
repeatString str n =
    if n == 0
    then "" -- Дъно на рекурсията
    else str ++ (repeatString str (n-1)) -- Рекурсия

-- Главен метод
main = do
   
    -- Един път извеждаме "Please Input Number: "
    putStrLn(repeatString "Please Input Number: " 1)

    -- Четем числото n 
    line <- getLine
    let n = read line :: Int

    -- Повтаряме низа "Hello" n на брой пъти 
    putStrLn(repeatString "Hello" n)
