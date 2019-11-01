maxOfThree :: Int -> Int -> Int -> Int
maxOfThree a b c =
    max (max a b) c
    

main = do
    firstLine <- getLine
    secondLine <- getLine
    thirdLine <- getLine
    let a = read firstLine :: Int
    let b = read secondLine :: Int
    let c = read thirdLine :: Int
    let maxVal = (maxOfThree a b c) :: Int
    putStrLn(show maxVal)