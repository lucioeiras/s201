(defun funcao(x)
  (if (>= x 4)
      (* x x)  
      (/ x 2)))  

(defparameter l1 (list 1 2 3))
(defparameter l2 (list 4 5 6))

(defparameter l3 (mapcar #'funcao l1))
(defparameter l4 (mapcar #'funcao l2))

(print (append l3 l4))