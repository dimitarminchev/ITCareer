getListLength list = 
    if null list
    then 0
    else 1 + (getListLength (tail list))

main = do
    let list1 = [123,456]
    let list2 = [1]
    let list3 = []
    let list4 = "Hello, world!"
    putStrLn(show(getListLength list1))
    putStrLn(show(getListLength list2))
    putStrLn(show(getListLength list3))
    putStrLn(show(getListLength list4))