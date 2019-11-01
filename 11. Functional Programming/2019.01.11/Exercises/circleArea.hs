main = do
    firstLine <- getLine
    let radius = read firstLine :: Float
    let result = radius * radius * pi
    putStrLn(show(result))