-- 2. Functions: pow2
pow2 n =
    if n == 0
    then 1
    else 2 * (pow2 (n - 1))

main = do
    putStrLn (show(pow2 10))
    -- Result = 1024