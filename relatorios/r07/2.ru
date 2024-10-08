class Carro
  def descrever
    "Um carro qualquer"
  end
end

class CarroEsportivo < Carro
  def descrever
    "Um carro esportivo é feito para alta performance e atingir altas velocidades,
mesmo que isso custe o conforto e comodidade de um carro normal."
  end
end

class CarroSedan < Carro
  def descrever
    "Um carro sedan é um carro espaçoso que possui muito espaço interno e um 
grande porta-malas"
  end
end

carro = Carro.new
esportivo = CarroEsportivo.new
sedan = CarroSedan.new

puts carro.descrever
puts esportivo.descrever
puts sedan.descrever