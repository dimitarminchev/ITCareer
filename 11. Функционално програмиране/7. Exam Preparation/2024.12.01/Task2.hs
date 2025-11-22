main :: IO ()
main = do
    a <- readLn :: IO Int
    b <- readLn :: IO Int
    
    let (start, end) = if a > b then (b, a) else (a, b)
    
    let sumOfOdds = sum [x | x <- [start..end], odd x]    
    
    print sumOfOdds