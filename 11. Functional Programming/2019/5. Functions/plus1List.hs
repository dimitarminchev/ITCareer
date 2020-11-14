-- 5. Fuctions

plus1List list = map (1 + ) list

main = do
   putStrLn(show(plus1List [1,2,3,4,5])) -- [2,3,4,5,6]
