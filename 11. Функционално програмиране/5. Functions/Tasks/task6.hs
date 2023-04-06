-- Зад. 6 Отрязване на списък
sliceList list start end =
    drop (start) (take (end + 1) list)

main = do
    putStrLn(show(sliceList [1,2,3,4,5] 1 2)) -- [2,3]
    putStrLn(show(sliceList [1,2,3,4,5] 0 4)) -- [1,2,3,4,5]
    putStrLn(show(sliceList [1,2,3,4] 0 10)) -- [1,2,3,4]