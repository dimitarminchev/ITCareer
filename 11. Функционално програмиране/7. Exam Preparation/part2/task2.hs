-- Импортираме библиотека Data.Char заради функциите isLower и isUpper
import Data.Char

-- Функция за филтриране само на малки букви
onlyLowers = (filter isLower)

-- Функция за филтриране само на големи букви
onlyUppers = (filter isUpper)

-- Глвна функция
main = do

    -- Въвеждаме от стандартният вход 
    line <- getLine

    -- Боячи
    let lowers = (length (onlyLowers line))
    let uppers = (length (onlyUppers line))
    let symbols = (((length line) - lowers) - uppers)

    -- Отпечаване на стандартният изход
    putStrLn( show(lowers) ++ " " ++ show(uppers) ++ " " ++ show(symbols))