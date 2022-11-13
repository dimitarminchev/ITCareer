-- Задача 1.

-- Функция за отпечатване на името и фамилията
firstAndLastName :: IO()
firstAndLastName = do
    -- Въвеждане на име
    firstname <- getLine
    
    -- Въвеждане на фамилия
    lastname <- getLine

    -- Отпечатваме име и фамилие
    putStrLn (firstname ++ "  " ++ falastnamemily)

-- Главна функция
main :: IO ()
main = do

    -- Изпълнение на фунцкия
   firstAndLastName
