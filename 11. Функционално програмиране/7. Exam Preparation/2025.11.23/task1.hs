import Text.Printf (printf)

main :: IO ()
main = do
    inputLeva <- getLine
    inputRate <- getLine
    inputComm <- getLine

    let maybeLeva = reads inputLeva :: [(Double, String)]
        maybeRate = reads inputRate :: [(Double, String)]
        maybeComm = reads inputComm :: [(Double, String)]

    if null maybeLeva || null maybeRate || null maybeComm then
        putStrLn "Invalid input data!"
    else
        let (leva, _) = head maybeLeva
            (rate, _) = head maybeRate
            (comm, _) = head maybeComm
        in
        if leva <= 0 || rate <= 0 || comm < 0 || comm > 100 then
            putStrLn "Invalid input data!"
        else
            let euroBefore = leva / rate
                fee        = euroBefore * (comm / 100)
                euroAfter  = euroBefore - fee
            in printf "Final amount: %.2f EUR\n" euroAfter
