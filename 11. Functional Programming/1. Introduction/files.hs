-- Introduction: Writing and Reading Files
desktopFile = "C:\\Users\\dimit\\Desktop\\TextFile.txt"

main :: IO()
main = do
    -- Writing to File
    writeFile desktopFile "This is one line of text."

    -- Append Line to File
    appendFile desktopFile "This is second line of text."

    -- Reading from File
    file <- readFile desktopFile
    putStrLn file