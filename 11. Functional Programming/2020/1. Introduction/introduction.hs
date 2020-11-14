-- Introduction Haskell Program

-- Func -> String
dummyGetLine :: IO String
dummyGetLine = 
    return "Please enter yor name: "

-- Main
main :: IO ()
main = do

    -- Execute func: dummyGetLine
    dummy <- dummyGetLine
    putStrLn dummy

    -- Read a line from console
    line <- getLine 

    -- Print the string
    putStrLn ("Echo: " ++ line)