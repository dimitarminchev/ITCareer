import Data.Char

minFromList list = foldl min (head list) list

main = do
    line <- getLine 
    putStrLn (show (minFromList (map (digitToInt) line)))
