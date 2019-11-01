add1 n = n + 1

remove1 n = n - 1

compose f n = f n

main = do
    simFunc <- getLine
    valueLine <- getLine
    let value = read valueLine :: Int
    if simFunc == "add1"
    then putStrLn(show(compose add1 value))
    else putStrLn (show(compose remove1 value))
    