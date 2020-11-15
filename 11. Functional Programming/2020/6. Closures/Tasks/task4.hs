-- Зад. 4 Генериране на математически израз
convert str = 
    (
        \a ->
        if null str
        then str ++ show(a)
        else "(" ++ str ++ "+" ++ show(a) ++ ")"
    )
mathExp list = foldl convert "" list

-- Главен метод/функция
main = do
    -- Вход ниданни
    let testList1 = [1,2,3,4,5] :: [Int] -- [1,2,3,4,5]
    let testList2 = [1] :: [Int] -- 1
    let testList3 = [1,10] :: [Int] -- [1,10]
    let testList4 = [] :: [Int] -- []
    -- Изходни данни
    putStrLn(mathExp testList1) -- ((((1+2)+3)+4)+5)
    putStrLn(mathExp testList2) -- 1
    putStrLn(mathExp testList3) -- (1+10)
    putStrLn(mathExp testList4) -- []