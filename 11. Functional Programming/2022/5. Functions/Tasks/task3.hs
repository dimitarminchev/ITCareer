-- Зад. 3 Компресиране на списък
removeIdentical :: Int -> [Int] -> [Int] 
removeIdentical a b =
    if a == head b
    then b
    else a : b

compressList [] = []
compressList list = foldr removeIdentical [last list] list

main = do
    
    let testList1 = [1,1,1,1,1,1,1,1,1,1,2,3,4,5,6,7,8] :: [Int]
    let testList2 = [1] :: [Int]
    let testList3 = [1,10] :: [Int]
    let testList4 = [] :: [Int]

    putStrLn(show(compressList testList1)) -- [1,2,3,4,5,7,8]
    putStrLn(show(compressList testList2)) -- 1
    putStrLn(show(compressList testList3)) -- [1,10]
    putStrLn(show(compressList testList4)) -- [] 