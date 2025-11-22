import Data.Char

-- Рекурсивен метод за обръщане на стринг
reverseStringLoop str newStr = 
    if null str
    then newStr
    else reverseStringLoop (tail str) ((head str) : newStr)

-- Помощен метод за обръщане на стринг
reverseString str = reverseStringLoop str []

-- Входна точка на програмата
main :: IO ()
main = do

    -- Четем един ред като стринг
    input <- getLine

    -- Обръщаме регистъра на всички букви в малки
    let word = map toLower input

    -- Обръщане на думата наобратно
    let reversed = reverseString word

    -- Отпечатваме крайният резултат
    if word == reversed
    then putStrLn "Palindrome"
    else putStrLn "Not palindrome"