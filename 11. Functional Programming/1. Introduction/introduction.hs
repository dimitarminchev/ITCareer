-- Introduction: IO Example
dummyGetLine :: IO String
dummyGetLine =
    return "Please enter your name: "

main :: IO()
main = do
    -- Write Line
    line <- dummyGetLine
    putStrLn line
    -- Read Line and Print It
    line <- getLine
    putStrLn ("Welcome to Haskell, " ++ line)