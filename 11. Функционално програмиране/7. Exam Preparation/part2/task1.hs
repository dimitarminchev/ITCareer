-- Trubinacci Sequence: 0 0 1 1 2 4 7 ... f[n] = f[n-3] + f[n-2] + f[n-1] 

-- Рекурсивна функция за намиране на числата от редицата на Трибуначи
tri n =
    if n == 0 || n == 1
    then 0
    else if n == 2
         then 1
         else tri(n-3) + tri(n-2) + tri(n-1)

-- Главна функция
main = do

    -- Въвеждаме от стандартният вход 
    line <- getLine

    -- Конверираме към цяло число
    let number = read line :: Int

    -- Използваме рекурсивната функция и отпечатваме резултата
    putStrLn(show(tri number))