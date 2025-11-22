import Text.Printf(printf)

main :: IO ()

main = do 
    -- Четем: начална цена, цена на километър, разстояние в километри 
    begginingPriceStr <- getLine
    pricePerKilometerStr <- getLine
    distanceStr <- getLine

    -- Конвертиране: String -> Double
    let begginingPrice = read begginingPriceStr :: Double
    let pricePerKilometer = read pricePerKilometerStr :: Double 
    let distance = read distanceStr :: Double 

    -- Изчисляваме крайна цена, закръглвена до втория знак
    let endPrice = begginingPrice + (pricePerKilometer * distance)
    let rounded = printf ("%." ++ show 2 ++ "f") endPrice

    -- Проверка на входните данни
    if begginingPrice < 0 || pricePerKilometer < 0 || distance < 0
    then putStrLn "Invalid input data!"
    else putStrLn ("Price: " ++ rounded ++ " lv.")