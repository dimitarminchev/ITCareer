-- 5. Functions

absoluteList list = map abs list

main = do
   putStrLn(show(absoluteList [1,2,-3,-4])) -- [1,2,3,4]
