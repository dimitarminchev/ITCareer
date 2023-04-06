-- Рекурсивна функция за намиране на факториел
fak n =
    if n == 1 
    then 1 -- Дъно на рекурсията 
    else n * (fak (n - 1)) -- Рекурсия
    
-- Главна функция
main = do

     -- Четем число, извършваме желаните операции и отпечтваме резултата
    line <- getLine
    let number = read line :: Int
    putStrLn (show(fak number))
    -- Input: 5, Output: 120