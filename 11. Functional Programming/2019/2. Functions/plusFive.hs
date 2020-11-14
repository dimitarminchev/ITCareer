-- 2. Functions: plusFive
plusFive n = 
    if n < 0
    then (-n) + 5
    else n + 5

plusFive' n = (abs n) + 5

main = do
    putStrLn (show(plusFive'(7)))
    -- Result = 12