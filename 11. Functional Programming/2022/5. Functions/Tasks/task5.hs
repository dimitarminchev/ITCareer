-- Зад. 5 Репликация на списъчни елементи
replicateElement x 0 = []
replicateElement x n = x : replicateElement x (n-1)
replicateList [] _ = []
replicateList list n = foldl (\x y -> x ++ replicateElement y n) [] list

main = do
    putStrLn(show(replicateList [1,2,3,4,5] 2)) -- [1,1,2,2,3,3,4,4,5,5]
    putStrLn(show(replicateList [1,2] 5)) -- [1,1,1,1,1,2,2,2,2,2]
    putStrLn(show(replicateList [1,2,3] 0)) -- []
    putStrLn(show(replicateList ([] :: [Int]) 10)) -- []
