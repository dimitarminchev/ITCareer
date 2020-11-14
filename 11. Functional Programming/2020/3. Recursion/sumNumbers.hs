-- Метод за намиране на сума на числа
sumNumbers = sumNumbersLoop 0 1

-- Помощен метод за извършване на рекурсия
sumNumbersLoop sum index = 
    if index > 10
    then sum
    else (sum + index) + (sumNumbersLoop sum (index + 1))

-- Главен метод
main = do
     -- Извеждане на резултата
     putStrLn(show(sumNumbers))   