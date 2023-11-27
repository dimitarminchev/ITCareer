import Data.Char (isDigit)

isNum :: String -> Bool
isNum str = all isDigit str

main :: IO ()
main = do
    str <- getLine
    if length str /= 4 || not (isNum str)
    then putStrLn "Invalid code"
    else
        let [first, second, third, fourth] = str in 
            if first == fourth && second == third
            then putStrLn "Unlock"
            else putStrLn "Not unlock"