-- 4. Lists

doubleList list = 
    if null list
    then []
    else (2 * (head list) : (doubleList (tail list)))

main = do
   putStrLn (show(doubleList [1,2,3,4,5])) -- [2,4,6,8,10]
