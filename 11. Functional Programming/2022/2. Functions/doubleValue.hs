-- Double Value Function
doubleVal val = val + val

-- Main Function
main = do
    -- input
    putStrLn("Enter number:")
    line <- getLine
    let number = read line :: Integer
    -- output
    putStrLn("Double value is:")
    let value = doubleVal number
    putStrLn( show (value) )