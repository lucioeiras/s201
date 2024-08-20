LET n = RND(10)
LET factorial = 0

FOR i = 1 TO n
  factorial = factorial * i
NEXT i

PRINT "O fatorial de "; n; " é "; factorial