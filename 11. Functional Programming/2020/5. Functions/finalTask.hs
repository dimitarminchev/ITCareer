-- Сбор на два елемента
main = do

    -- Извършване на операцията и отпечатване на резултата
    let listPlus= zipWith (\ x y -> x + y) [10,12] [3,4]
    putStrLn(show(listPlus)) -- [13,16]

    let listMunus = zipWith (\ x y -> x - y) [1,2,3,4,5,6,7,8,9] [9,8,7,6,5,4,3,2,1]
    putStrLn(show(listMunus)) -- [-8,-6,-4,-2,0,2,4,6,8]
