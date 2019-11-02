duplicateList list =
    if null list
    then []
    else head list : head list : duplicateList (tail list)

main = do
    let list1 = "abc"
    let list2 = [1,2,3]
    let list3 = [1]
    let list4 = []
    putStrLn(show(duplicateList list1))
    putStrLn(show(duplicateList list2))
    putStrLn(show(duplicateList list3))
    putStrLn(show((duplicateList list4) :: [Int]))