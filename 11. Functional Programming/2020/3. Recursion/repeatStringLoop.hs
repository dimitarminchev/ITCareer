-- Помощна рекурсивна функция за повторение на низ
repeatStringLoop string result n = 
    if n == 0
    then result
    else repeatStringLoop string (result ++ string) (n - 1)

-- Функция която връща n повторение на низ string
repeatString string n = repeatStringLoop string string n

-- Главна функция
main = do

    -- repeatString "Hello" 10
    putStrLn (repeatString "Hello" 10)
    --- HelloHelloHelloHelloHelloHelloHelloHelloHelloHello
