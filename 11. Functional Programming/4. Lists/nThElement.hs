-- 4. Lists

nThElement list n = nThElementLoop list (length list) n 0
nThElement [] _ = error "Empty list" 
nThElementLoop list listLength n index =
    if n >= listLength || n < 0
    then error "Index outside bounds of array"
    else if index == n
         then (head list)
         else nThElementLoop (tail list) listLength n (index + 1)

main = do
    putStrLn (show(nThElement [1,2,3,4,5,6,7,8,9] 7)) -- 8