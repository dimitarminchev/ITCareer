-- 4. Lists

createList start end = createListLoop [] start end
createListLoop list start end =
    if start > end
    then list
    else createListLoop (list ++ [start]) (start + 1) end

main = do
    putStrLn (show(createList 1 10)) -- [1,2,3,4,5,6,7,8,9,10]