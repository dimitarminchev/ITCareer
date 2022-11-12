main = do

   -- Input 2 line of strings
   putStrLn("Enter first name:")
   firstName <- getLine
   putStrLn("Enter last name:")
   lastName <- getLine

   -- Output 1 line concatinationg the 2 inputs
   putStrLn("Full name is:")
   putStrLn(firstName ++ " " ++ lastName)