-- 4. Lists

createReverseList start end = createReverseListLoop [] start end
createReverseListLoop list start end =
    if start > end
    then list
    else createReverseListLoop (start : list) (start + 1) end

main = do
    putStrLn (show(createReverseList 1 10)) -- [10,9,8,7,6,5,4,3,2,1]