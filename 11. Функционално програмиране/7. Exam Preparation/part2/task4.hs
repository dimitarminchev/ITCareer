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

-- Рекурсивна функция за отпечатване на правоъгълник
printRectangle n stars =
    if(n == 0)
    then return()
    else do
        putStrLn(asterixStringRow stars) 
        printRectangle (n - 1) stars

-- Проверки
conditions s n = case s of
    "triangle" -> printTriangle n 
    "rectangle" -> printRectangle n n
    _ -> putStrLn("Invalid figure!")

-- Главна функция
main = do
    
    -- Въвеждаме от стандартният вход
    s <- getLine
    nString <- getLine
    let n = read nString :: Int

    -- Отпечаване на стандартният изход
    conditions s n
