-- 5. Functions

main = do
    let z1 =  (zip [1,3,5] [2,4,6]) 
    putStrLn(show(z1)) -- [(1,2),(3,4),(5,6)]

    let z2  = (zipWith (+) [1,2,3,4,5] [9,8,7,6,5])
    let z3 = (zipWith (-) [1,2,3,4,5] [9,8,7,6,5])
    putStrLn(show(z2))  -- [10,10,10,10,10]
    putStrLn(show(z3)) -- [-8,-6,-4,-2,0]