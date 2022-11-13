-- Функция за сумиране на числата от 1 до 10
sumNumbers = sumNumbersLoop 0 1

-- Рекурсивна функция реализираща цикъл от 1 до 10
sumNumbersLoop sum index = 
    if index > 10
    then sum
    else (sum + index) + (sumNumbersLoop sum (index + 1))

-- Главна функция
main = do
    putStrLn(show(sumNumbers)) -- Result: 55 = 1+2+3+4+5+6+7+8+9+10