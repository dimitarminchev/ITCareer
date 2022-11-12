-- Files Haskell Program

-- File Path
filePath = "C:\\Users\\mitko\\Desktop\\ITCareer\\11. Functional Programming\\2022\\1. Introduction\\files.txt"

-- Main
main :: IO ()
main = do

    -- Write
    writeFile filePath "This is one line of text wrtitten in file.\n"

    -- Append
    appendFile filePath "This is second line of thext in the file."

    -- Read
    file <- readFile filePath
    putStrLn file