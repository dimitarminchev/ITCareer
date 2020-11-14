-- Рекурсивна функция за изчертаване на ASCII триъгълник
printTriangle n = do
   if n > 0
   then do
       let row = printRow n
       putStrLn row
       printTriangle (n-1)
   else return()

-- Рекурсиван функция за генериране на n на брой звезди
printRow n =
    if n == 0
    then "" -- Дъно на рекурсията
    else "*" ++ printRow (n-1) -- Рекурсия

-- Главна функция 
main :: IO()
main = do

     -- Четем входни данни, обработваме ги и звеждаме резултата
    input <- getLine
    let n = read input :: Int
    printTriangle n
