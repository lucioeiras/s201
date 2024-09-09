package main

import (
	"fmt"
	"math"
)

func main() {
	var a, b, c float64

	fmt.Print("A: ")
	fmt.Scan(&a)

	fmt.Print("B: ")
	fmt.Scan(&b)

	fmt.Print("C: ")
	fmt.Scan(&c)

	delta := math.Pow(b, 2) - 4*a*c

	if delta < 0 {
		fmt.Println("Não existe raízes")
	} else if delta == 0 {
		raiz1 := -b / (2 * a)
		fmt.Printf("Existe apenas uma raíz: %f\n", raiz1)
	} else {
		raiz1 := (-b + math.Sqrt(delta)) / (2 * a)
		raiz2 := (-b - math.Sqrt(delta)) / (2 * a)
		fmt.Printf("Existem 2 raízes: %f e %f\n", raiz1, raiz2)
	}
}
