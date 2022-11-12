-- Най-голямото от три числа
biggestOf3 a b c =
    max (max a b) c

-- Главна функция
main = do

    -- Четем три числа, проверяваме и отпечтваме резултата
    firstLine <- getLine
    secondLine <- getLine
    thirdLine <- getLine
	
    let a = read firstLine :: Int
    let b = read secondLine :: Int
    let c = read thirdLine :: Int
	
    let maxVal = (biggestOf3 a b c) :: Int
    putStrLn(show maxVal)