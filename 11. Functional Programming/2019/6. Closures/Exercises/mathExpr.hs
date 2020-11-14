convert str= 
    (
        \a ->
        if null str
        then str ++ show(a)
        else "(" ++ str ++ "+" ++ show(a) ++ ")"
    )

mathExp list = foldl convert "" list

main = do
    let testList1 = [1,2,3,4,5] :: [Int]
    let testList2 = [1] :: [Int]
    let testList3 = [1,10] :: [Int]
    let testList4 = [] :: [Int]
    putStrLn(mathExp testList1)
    putStrLn(mathExp testList2)
    putStrLn(mathExp testList3)
    putStrLn(mathExp testList4)