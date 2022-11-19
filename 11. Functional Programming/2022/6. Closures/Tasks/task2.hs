-- Зад. 2 Най-голямо от три числа
maxOfThree a b = (\c -> max (max a b) c)

main = do
      
      putStrLn(show(maxOfThree 5 10 20)) -- 20
      putStrLn(show(maxOfThree 5 10 (-20 :: Int))) -- 10