-- 5. Fuctions
abstThroughFunction a b func = func a b
firstFunc a b = (a * b)
secondFunc a b = (a + b)
thirdFunc a b = (a - b)

main = do
    putStrLn(show(abstThroughFunction 10 10 firstFunc)) -- 100
    putStrLn(show(abstThroughFunction 10 10 secondFunc)) -- 20
    putStrLn(show(abstThroughFunction 10 10 thirdFunc)) -- 0
