sliceList list start end =
    drop (start) (take (end + 1) list)

main = do
    putStrLn(show(sliceList [1,2,3,4,5] 1 2))
    putStrLn(show(sliceList [1,2,3,4,5] 0 4))
    putStrLn(show(sliceList ([] :: [Int]) 1 0))
    putStrLn(show(sliceList ([] :: [Int]) 5 5))
    putStrLn(show(sliceList [1,2,3,4] 0 10))