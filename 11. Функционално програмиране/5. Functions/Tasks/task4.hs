-- Зад. 4 Дупликация на списъчни елементи
duplicateElement a b = a : a : b
duplicateList list = foldr duplicateElement [] list

main = do

    let list1 = [1,2,3,4] :: [Int]
    let list2 = [1,2,3,4,4] :: [Int]
    let list3 = [1] :: [Int]
    let list4 = [] :: [Int]

    putStrLn(show(duplicateList list1)) -- [1,1,2,2,3,3,4,4]
    putStrLn(show(duplicateList list2)) -- [1,1,2,2,3,3,4,4,4,4]
    putStrLn(show(duplicateList list3)) -- [1,1]
    putStrLn(show(duplicateList list4)) -- []