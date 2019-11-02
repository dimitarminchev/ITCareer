main = do
    firstLine <- getLine
    secondLine <- getLine
    thirdLine <- getLine
    fourthLine <- getLine
    fifthLine <- getLine
    sixthLine <- getLine
    let xLowerLeft = read firstLine :: Int
    let yLowerLeft = read secondLine :: Int
    let xUpperRight = read thirdLine :: Int
    let yUpperRight = read fourthLine :: Int 
    let xPoint = read fifthLine :: Int
    let yPoint = read sixthLine :: Int

    let isInRow = xPoint >= xLowerLeft && xPoint <= xUpperRight
    let isInCol = yPoint >= yLowerLeft && yPoint <= yUpperRight
    let isInRectangle = isInCol && isInRow
    if isInRectangle
    then
        putStrLn("INSIDE")
    else
        putStrLn("OUTSIDE")