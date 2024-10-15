using System;

class Cachorro {
  public string Nome { get; set; }
  public int Idade { get; set; }

  public Cachorro(string nome, int idade) {
    Nome = nome;
    Idade = idade;
  }

  public void MostrarNome() {
    Console.WriteLine($"Nome do cachorro: {Nome}");
  }

  public virtual void MostrarIdade() {
    Console.WriteLine($"Idade do cachorro: {Idade}");
  }
}

class CachorroGrande : Cachorro {
  private string Tamanho { get; set; }

  public CachorroGrande(string nome, int idade, string tamanho) 
    : base(nome, idade) {
    Tamanho = tamanho;
  }

  public override void MostrarIdade() {
    Console.WriteLine($"Idade do cachorro grande: {Idade}");
  }

  public void MostrarTamanho() {
    Console.WriteLine($"Tamanho do cachorro grande: {Tamanho}");
  }
}

class CachorroPequeno : Cachorro {
  public CachorroPequeno(string nome, int idade) 
    : base(nome, idade) {
  }

  public override void MostrarIdade() {
    Console.WriteLine($"Idade do cachorro pequeno: {Idade}");
  }
}

class Program {
  static void MostrarInformacoes(Cachorro cachorro) {
    cachorro.MostrarNome();
    cachorro.MostrarIdade();

    if (cachorro is CachorroGrande grande) {
      grande.MostrarTamanho();
    }
  }

  static void Main(string[] args) {
    Cachorro cachorro = new Cachorro("Mohamad", 5);
    CachorroPequeno cachorroPequeno = new CachorroPequeno("Lupita", 2);
    CachorroGrande cachorroGrande = new CachorroGrande("Teddy", 7, "Grande");

    Console.WriteLine("Cachorro normal:");
    MostrarInformacoes(cachorro);
    Console.WriteLine();

    Console.WriteLine("Cachorro pequeno:");
    MostrarInformacoes(cachorroPequeno);
    Console.WriteLine();

    Console.WriteLine("Cachorro grande:");
    MostrarInformacoes(cachorroGrande);
  }
}