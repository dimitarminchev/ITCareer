-- 3. Recursion

pow2loop n x i = 
    if i < n
    then pow2loop n (x*2) (i+1)
    else x

pow2 n = pow2loop n 1 0

main = do
    putStrLn (show(pow2 10)) -- 1024