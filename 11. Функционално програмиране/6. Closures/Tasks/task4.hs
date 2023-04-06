-- Зад. 4 Генериране на математически израз
convert str = 
    (
        \x ->
        if null str
        then str ++ show(x)
        else "(" ++ str ++ "+" ++ show(x) ++ ")"
    )
mathExp list = foldl convert "" list

-- Главен метод/функция
main = do

    let list = [1,2,3,4,5] :: [Int] -- [1,2,3,4,5]

    putStrLn(mathExp list) -- ((((1+2)+3)+4)+5)