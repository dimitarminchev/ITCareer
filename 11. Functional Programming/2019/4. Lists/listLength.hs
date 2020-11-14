-- 4. Lists

listLength [] = 0
listLength list = findLength 1 list
findLength length list = 
    if null list
    then (length - 1)
    else findLength (length + 1) (tail list)

main = do
   let list = [1,2,3,4,5] 
   putStrLn (show(listLength list)) -- 5