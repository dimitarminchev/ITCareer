-- Прилагане на функция ZIP
main = do
    
    -- Създаване на списъци 1
    let listA = [1,3,5]
    let listB = [2,4,6]
    let listC = zip [1,3,5] [2,4,6]
    putStrLn("\nPart 1")
    putStrLn(show(listA)) -- [1,3,5]
    putStrLn(show(listB)) -- [2,4,6]
    putStrLn(show(listC)) -- [(1,2),(3,4),(5,6)]

    -- Създаване на списъци 2
    let listA = [1,2]
    let listB = [3,4,5,6]
    let listC = zip [1,2] [3,4,5,6]
    putStrLn("\nPart 2")
    putStrLn(show(listA)) -- [1,2]
    putStrLn(show(listB)) -- [3,4,5,6]
    putStrLn(show(listC)) -- [(1,3),(2,4)]

    -- Създаване на списъци 3
    let listA = [1,2,3,4,5]
    let listB = [9,8,7,6,5]
    let listC = zipWith (+) [1,2,3,4,5] [9,8,7,6,5]
    putStrLn("\nPart 3")
    putStrLn(show(listA)) -- [1,2,3,4,5]
    putStrLn(show(listB)) -- [9,8,7,6,5]
    putStrLn(show(listC)) -- [10,10,10,10,10]
