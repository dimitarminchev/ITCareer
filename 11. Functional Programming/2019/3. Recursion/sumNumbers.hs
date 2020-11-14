-- 3. Recursion

sumNumbers = sumNumbersLoop 0 1

sumNumbersLoop sum index = 
    if index > 10
    then sum
    else (sum + index) + (sumNumbersLoop sum (index + 1))

main = do
    putStrLn (show(sumNumbers)) -- 55