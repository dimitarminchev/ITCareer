-- Задача 4.

-- Функция за намиране дали дадена точка е част от правоъгълник
findPointPosition = do

    -- Въвеждане на данните
    line1 <- getLine
    line2 <- getLine
    line3 <- getLine
    line4 <- getLine
    line5 <- getLine
    line6 <- getLine

    -- Намиране на лице на кръга
    let x1 = read line1 :: Int
    let y1 = read line2 :: Int
    let x2 = read line3 :: Int
    let y2 = read line4 :: Int
    let x = read line5 :: Int
    let y = read line6 :: Int

    -- Отпечатваме резултата
    if x >= x1 && x <= x2 && y >= y1 && y <= y2 
    then putStrLn "INSIDE"
    else putStrLn "OUTSIDE"

-- Главна функция
main = do

    -- Изпълнение на фунцкия
   findPointPosition
