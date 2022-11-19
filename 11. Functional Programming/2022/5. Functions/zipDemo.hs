main = do

    let list = [1,3,5,7]
    let list' = [2,4,6,8]
    let list'' = zip list list'
    
    putStrLn(show(list)) -- [1,3,5,7]
    putStrLn(show(list')) -- [2,4,6,8]
    putStrLn(show(list'')) -- [(1,2),(3,4),(5,6)]
