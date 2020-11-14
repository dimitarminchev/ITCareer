-- Задача 1.

-- Функция за отпечатване на името и фамилията
printName :: IO()
printName = do
    -- Въвеждане на име
    name <- getLine
    
    -- Въвеждане на фамилия
    family <- getLine

    -- Отпечатваме име и фамилие
    putStrLn (name ++ "  " ++ family)

-- Главна функция
main :: IO ()
main = do

    -- Изпълнение на фунцкия
   printName
