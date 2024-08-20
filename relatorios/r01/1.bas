INPUT a
INPUT b
INPUT c

delta = b * b - 4 * a * c

IF delta < 0 THEN
    PRINT "Essa equação não possui raízes"
ELSEIF delta = 0 THEN
    x = -b / (2 * a)
    PRINT "Essa equação possui uma raiz: "; x
ELSE
    x1 = (-b + SQR(delta)) / (2 * a)
    x2 = (-b - SQR(delta)) / (2 * a)
    PRINT "Essa equação possui duas raízes reais: "
    PRINT "x' = "; x1
    PRINT "x'' = "; x2
END IF