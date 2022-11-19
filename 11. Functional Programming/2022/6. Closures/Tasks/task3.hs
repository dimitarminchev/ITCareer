-- Зад. 3 Подаване на функция като аргумент на функция
add1 = (\x -> x + 1)
remove1 = (\x -> x - 1)

-- Сложна съставна функция
compose x = (\func -> func x)

main = do
      
      putStrLn(show(compose 5 add1)) -- 6
      putStrLn(show(compose 5 remove1)) -- 4