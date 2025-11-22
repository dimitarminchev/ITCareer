import Text.Printf (printf)

main :: IO ()

main = do
    x1 <- readLn :: IO Double
    y1 <- readLn :: IO Double
    x2 <- readLn :: IO Double
    y2 <- readLn :: IO Double
    
    let width = abs (x2 - x1)
    let height = abs (y2 - y1)
    
    let area = width * height
    let perimeter = 2 * (width + height)
    
    printf "S=%.2f\n" area
    printf "P=%.2f\n" perimeter