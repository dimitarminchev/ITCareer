deleteEveryNthElement :: [Int] -> Int -> [Int]
deleteEveryNthElement list n =
    if length list < n
    then list
    else (take (n - 1) list) ++ (deleteEveryNthElement (drop n list) n)

main = do
    let list1 = [1,2,3,4,5,6,7,8,9]
    let list2 = [1,2,3]
    let list3 = []
    putStrLn(show(deleteEveryNthElement list1 3))
    putStrLn(show((deleteEveryNthElement list1 1) :: [Int]))
    putStrLn(show(deleteEveryNthElement list2 3))
    putStrLn(show((deleteEveryNthElement list3 3) :: [Int]))