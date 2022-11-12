main = do

    -- Input 6 lines of string
    putStrLn("Enter rectangle Ax & Ay:")
    pointAXLine <- getLine
    pointAYLine <- getLine
    putStrLn("Enter rectangle Bx & By:")
    pointBXLine <- getLine
    pointBYLine <- getLine
    putStrLn("Enter point Cx & Cy:")
    pointCXLine <- getLine
    pointCYLine <- getLine

    -- Convert 6 string to integer numbers
    let pointAX = read pointAXLine :: Integer
    let pointAY = read pointAYLine :: Integer
    let pointBX = read pointBXLine :: Integer
    let pointBY = read pointBYLine :: Integer
    let pointCX = read pointCXLine :: Integer
    let pointCY = read pointCYLine :: Integer

    -- Chech if point is in the Rectange
    if(pointCX >= pointAX && pointCX <= pointBX)
    then if (pointCY >= pointAY && pointCY <= pointBY)
        then putStrLn "INSIDE"
        else putStrLn "OUTSIDE"
    else putStrLn "OUTSIDE"