-- Помощна рекурсивна функция за намиране на втора степен
pow2loop n x i = 
    if i < n
    then pow2loop n (x*2) (i+1)
    else x 

-- Функция за намиране на втора степен
pow2 n = pow2loop n 1 0

-- Главна функция
main = do

    -- 2 ^ 10 = 1024
    putStrLn(show(pow2 10))