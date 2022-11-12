main = do

    -- input
    putStrLn("Enter circle radius:")
    line <- getLine
    let radius = read line :: Float

    -- output
    putStrLn("Area of the circle is:")
    putStrLn (show (radius * radius * pi))