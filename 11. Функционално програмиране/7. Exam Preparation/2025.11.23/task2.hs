import Data.Char (toLower)

main :: IO ()
main = do

    word <- getLine

    let vowels = "aeiouy"
        count = length [c | c <- word, toLower c `elem` vowels]
        
    if count == 0
        then putStrLn "No vowels"
        else putStrLn ("Vowels: " ++ show count)
