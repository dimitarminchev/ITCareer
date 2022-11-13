-- Рекурсивна функция за повторение на низ
repeatString str n = 
    if n == 0
    then ""
    else str ++ (repeatString str (n-1))

-- Главна функция
main = do

    putStrLn ( repeatString "Hello" 5 )
    -- Result: HelloHelloHelloHelloHello