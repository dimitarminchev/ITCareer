getFibList list currValue prevValue n i =
    if(n < i)
    then []
    else currValue : getFibList list (currValue + prevValue) currValue n (i+1)	

fibList n = getFibList [] 1 0 n 1

main = do
    input <- getLine
    let value = read input :: Int
    putStrLn(show((fibList value) :: [Int]))