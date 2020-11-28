import Data.Char

sumList list = foldr (+) 0 list

main = do
    line <- getLine 
    putStrLn (show (div (sumList (map (digitToInt) line)) (length line)))
