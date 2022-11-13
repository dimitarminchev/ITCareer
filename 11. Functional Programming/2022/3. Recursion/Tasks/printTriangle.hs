-- Рекурсивна функция която отпечатва n на брой звездички
asterixStringRow n =
    if(n == 1)
    then "*"
    else "*" ++ asterixStringRow (n-1)

-- Рекурсивна функция за отпечатване на триъгълник
printTriangle n =
    if(n == 0)
    then return()
    else do
        putStrLn(asterixStringRow n) 
        printTriangle (n - 1)

-- Главна функция
main = do
    printTriangle 5

