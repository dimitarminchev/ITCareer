-- Функция за обръщане на списък
reverseList [] = []
reverseList (x:xs) = reverseList xs ++ [x]

-- Главна функция
main = do
    let list = [1,2,3,4,5]
    putStrLn(show(reverseList list)) -- Result: [5,4,3,2,1]