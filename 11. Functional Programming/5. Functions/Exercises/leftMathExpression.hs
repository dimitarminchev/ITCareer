showPlus str x =
    if null str
    then show x
    else "(" ++ str ++ "+" ++ (show x) ++")"

genMathExp list = foldl showPlus "" list

main = do
    let list1 = [1,2,3,4,5] :: [Int]
    let list2 = [1] :: [Int] 
    let list3 = [] :: [Int] 
    let list4 = [1,10] :: [Int]
    putStrLn(genMathExp list1)
    putStrLn(genMathExp list2)
    putStrLn(genMathExp list3)
    putStrLn(genMathExp list4)