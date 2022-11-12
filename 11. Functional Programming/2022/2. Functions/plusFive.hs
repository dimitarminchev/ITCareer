plusFive n = 
    if n < 0
    then (-n) + 5
    else n + 5

plusFive' n = (abs n) + 5

main = do
    putStrLn( show( plusFive 5)) -- reult: 10
    putStrLn( show( plusFive' (-5))) -- result: 10