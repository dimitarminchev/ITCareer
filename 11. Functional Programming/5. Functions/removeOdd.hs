-- 5. Functions

isEven x = x `mod` 2 == 0
isOdd x = x `mod` 2 /= 0
removeOdd y = filter isEven y
removeEven y = filter isOdd y

main = do
   let list = [1,2,3,4,5,6,7,8,9,10]
   putStrLn(show(list)) -- [1,2,3,4,5,6,7,8,9,10]
   putStrLn(show(removeOdd list)) -- [2,4,6,8,10]
   putStrLn(show(removeEven list)) -- [1,3,5,7,9]