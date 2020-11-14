-- Рекурсивна функция за повторение на низ
repeatString str n =
    if n == 0
    then "" 
    else str ++ (repeatString str (n-1))

-- Главен метод
main = do
    putStrLn( repeatString "Hello" 12 )