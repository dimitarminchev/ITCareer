-- Функция за повдигане на степен
pow2loop n x i = 
    if i < n
    then pow2loop n (x*2) (i+1)
    else x

-- Функция за намиране на степен на двойката
pow2 n = pow2loop n 1 0

-- Главна функция
main = do
    putStrLn(show(pow2 3)) -- Result: 8
    putStrLn(show(pow2 10)) -- Result: 1024
