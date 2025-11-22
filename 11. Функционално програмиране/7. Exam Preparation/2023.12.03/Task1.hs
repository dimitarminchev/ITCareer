-- Функция за повторение на знак в низ
replicateSybol input num = concat (map (replicate num) input)

-- Главна входна точка на програмата
main = do

    -- Четем два ред а
    input <- getLine
    number <- getLine

    -- Преобразуваме вторият ред в цяло число
    let numbers = read number :: Int

    -- Изпълняваме функцията за повторение на знак в низ
    let perThings = replicateSybol input numbers

    -- Отпечатваме резултата
    print $ perThings