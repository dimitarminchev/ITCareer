-- 5. Functions

subtractList list = foldl (-) 0 list
subtractList' list = foldr (-) 0 list

main = do
    putStrLn(show(subtractList [1,2,3,4,5] )) -- -15
    putStrLn(show(subtractList' [1,2,3,4,5] )) -- 3