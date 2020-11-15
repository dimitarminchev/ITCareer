-- Рекурсивна функция която връща n-тия елемент от списъка
nThElemenLoop list listLength n index =
    if n >= listLength || n < 0
    then error "Index out of bounds of array"
    else if index == n
         then (head list)
         else nThElemenLoop (tail list) listLength n (index+1)

-- Помощни функции
nThElement list n = nThElemenLoop list (length list) n 0
nThElement [] _ = error "Empty list"

-- Главна функция
main = do
    -- Създаваме списък и извеждаме 7 елемент
    let list = [1,2,3,4,5,6,7,8,9,10]
    putStrLn(show(nThElement list 7)) -- 8