fatorial :: Integer -> Integer
fatorial n 
    | n > 0     = product [1..n]
    | otherwise = n * 2

main :: IO ()
main = do
    putStrLn "Escolha um número:"
    input <- getLine
    let n = read input :: Integer
    print (fatorial n)