-- Рекурсивна функция имплементираща цикъл
repeatStringLoop string result n = 
    if n <= 1
    then result
    else repeatStringLoop string (result ++ string) (n - 1)

-- Функция за повторение на низ
repeatString string n = repeatStringLoop string string n    

-- Главна функция
main = do
    putStrLn(repeatString "Hello" 5) 
    -- Result: HelloHelloHelloHelloHello