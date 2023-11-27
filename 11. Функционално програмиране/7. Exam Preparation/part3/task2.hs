stars :: Int -> String
stars count = replicate count '*'

spaces :: Int -> String
spaces count = replicate count ' '

genTree :: Int -> [String]
genTree size = (spaces size ++ "|") : [spaces (size - i) ++ stars i ++ "|" ++ stars i | i <- [1 .. size]]

drawChristmasTree :: Int -> IO ()
drawChristmasTree size = mapM_ putStrLn $ genTree size

main :: IO ()
main = do
    input <- getLine
    let size = read input :: Int
    if size > 0
    then drawChristmasTree size
    else putStrLn "Invalid input."