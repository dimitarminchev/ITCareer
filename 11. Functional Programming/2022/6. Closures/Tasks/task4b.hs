-- Зад. 4 Генериране на математически израз
convert str = 
    (
        \x ->
        if null str
        then (show x)
        else "(" ++ (show x) ++ "+" ++ str ++ ")"
    )
mathExp list = foldr convert "" list

-- Главен метод/функция
main = do

    let list = [1,2,3,4,5] :: [Int]
    putStrLn(mathExp list) -- (1+(2+(3+(4+(5)))))

