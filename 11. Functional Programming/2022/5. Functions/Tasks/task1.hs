-- 1. Генериране на математически израз
showPlus str x =
    if null str
    then show x
    else "(" ++ str ++ "+" ++ (show x) ++ ")"

genMathExp list = foldl showPlus "" list

main = do

    let list = [1,2,3,4,5] :: [Int]
    let list' = [1] :: [Int]
    let list'' = [1,10] :: [Int]
    let list''' = [] :: [Int]

    putStrLn(genMathExp list) -- ((((1+2)+3)+4)+5)
    putStrLn(genMathExp list') -- 1
    putStrLn(genMathExp list'') -- (1+10)
    putStrLn(genMathExp list''') -- []