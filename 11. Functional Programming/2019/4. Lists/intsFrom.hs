-- 4. Lists

intsFrom n = n : (intsFrom (n+1))
ints = intsFrom 1

main = do
    putStrLn(show(take 10 ints)) -- [1,2,3,4,5,6,7,8,9,10]