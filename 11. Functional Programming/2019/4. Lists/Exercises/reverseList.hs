
reverseList [] = []

reverseList (x:xs) = 
    reverseList xs ++ [x]

main = do
    let testList = [1,2,3,4,5]
    putStrLn (show (reverseList testList))
