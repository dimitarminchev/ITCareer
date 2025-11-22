import System.IO (isEOF)

-- Функция за генериране на ред от фигурата
generateRow :: Int -> Int -> String
generateRow height row =
    let spaces = replicate (height - row) ' '    
        dollars = replicate (2 * row - 1) '$'   
    in spaces ++ dollars

-- Функция за генериране на триъгълника
generateTriangle :: Int -> [String]
generateTriangle height = [generateRow height row | row <- [1..height]]

-- Входна точка на програмата
main :: IO ()
main = do
    
    -- Четем ред от конзолат под формата на низ
    input <- getLine

    -- Конвертираме го в цало число
    let height = read input :: Int

    -- Резултат
    if height < 0
    then putStrLn "Invalid value!"          
    else mapM_ putStrLn (generateTriangle height)  