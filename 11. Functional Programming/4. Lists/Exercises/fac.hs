getFacList list currValue n i =
    if(n < i)
    then []
    else currValue : getFacList list (currValue * i) n (i+1)	

facList n = getFacList [] 1 n 1

main = do
    input <- getLine
    let value = read input :: Int
    putStrLn(show((facList value) :: [Int]))