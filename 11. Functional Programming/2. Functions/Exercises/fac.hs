fac n =
    if n == 1
    then 1
    else n*fac(n-1)

main = do
    firstLine <- getLine
    let value = read firstLine :: Int
    putStrLn(show(fac value))