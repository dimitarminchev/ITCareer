-- Функция, която приема списък и число и връща n елемент от списъка
nThElement list n = nThElementLoop list (length list) n 0
nThElement [] _ = error "Empty list" 
nThElementLoop list listLength n index =
    if n >= listLength || n < 0
    then error "Index outside bounds of array"
    else if index == n - 1
         then (head list)
         else nThElementLoop (tail list) listLength n (index + 1)

-- Главна функция
main = do
    let list = [1,2,3,4,5,6,7,8,9,10]
    putStrLn(show(nThElement list 7)) -- Result: 7
