package main

import "fmt"

func factorial(n int) int {
	if n == 0 {
		return 1
	}

	resultado := 1

	for i := 1; i <= n; i++ {
		resultado *= i
	}

	return resultado
}

func main() {
	var num int

	fmt.Print("Digite um número: ")
	fmt.Scan(&num)

	result := factorial(num)
	fmt.Printf("O fatorial é %d\n", result)
}
