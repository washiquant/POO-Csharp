/////* 
////### 🙋 Exercício 1: Pessoa

////Crie a classe `Pessoa` com:

////- Atributos: `Nome` e `Idade`.
////- Método `Apresentar()`, que mostra uma frase de apresentação.

////Crie **dois objetos** diferentes e chame `Apresentar()` em cada um.
////*/
////using ConsoleApp1;
////Pessoa ser1 = new Pessoa();

////ser1.Nome = "Washington";
////ser1.Idade = 23;
////ser1.Apresentar();
////Pessoa ser2 = new Pessoa();
////ser2.Nome = "Joaozinho";
////ser2.Idade = 24;
////ser2.Apresentar();

/////*
//// * ### 📐 Exercício 2: Retângulo

////Crie a classe `Retangulo` com:

////- Atributos: `Largura` e `Altura` (números com casas decimais).
////- Método `CalcularArea()`, que **retorna** a área (largura × altura).
////- Método `CalcularPerimetro()`, que **retorna** o perímetro (2 × (largura + altura)).

////Os métodos não devem usar `Console.WriteLine`: quem mostra o resultado é o `Program.cs`.

////**Saída esperada** (largura 5, altura 3):

////```
////Área: 15
////Perímetro: 16
////```
////*/
////Retangulo objeto1 = new Retangulo();
////objeto1.Altura = 5;
////objeto1.Largura = 10;
////Console.WriteLine($"Area : {objeto1.CalcularArea}");
////Console.WriteLine($"Perimetro : {objeto1.CalcularPerimetro}");



//////### 💡 Exercício 3: Lâmpada

//////Crie a classe `Lampada` com:

//////-Atributo: `Ligada` (`bool`).
//////- Métodos: `Ligar()`, `Desligar()`, `E` (se está ligada, desliga; se está desligada, liga) e `ExibirEstado()`.

//////Crie uma lâmpada e chame, nesta ordem: `ExibirEstado()`, `Ligar()`, `ExibirEstado()`, `Alternar()`, `ExibirEstado()`.

//////**Saída esperada: **

//////```
//////A lâmpada está desligada.
//////A lâmpada está ligada.
//////A lâmpada está desligada.
//////```


////Lampada objeto2 = new Lampada();
////objeto2.ExibirEstado();
////objeto2.Ligar();
////objeto2.ExibirEstado();
////objeto2.Alternar();
////objeto2.ExibirEstado();

//////### 🏦 Exercício 4: Conta Bancária

//////Crie a classe `ContaBancaria` com:

//////-Atributos: `Titular` (texto) e `Saldo` (número com centavos).
//////- Método `Depositar(double valor)`: soma o valor ao saldo.
//////- Método `Sacar(double valor)`: só tira o dinheiro se houver saldo suficiente. Se não houver, mostra uma mensagem e o saldo não muda.
//////- Método `ExibirSaldo()`.

//////Teste: depositar 500, sacar 200, tentar sacar 1000 e exibir o saldo.

//////**Saída esperada:**

//////```
//////Depósito de R$ 500,00 realizado.
//////Saque de R$ 200,00 realizado.
//////Saldo insuficiente para sacar R$ 1000,00.
//////Saldo de Ana: R$ 300,00
//////```
//using ConsoleApp1;

//pessoa2 ana = new pessoa2();
//ana.Nome = "Ana";


//ana.Cumprimentar();
//ana.CumprimentarAlguem("Bruno");

//string frase = ana.ObterApresentacao();
//Console.WriteLine(frase);


using ConsoleApp1;

Cofrinho cofre = new Cofrinho("Ana");

cofre.Guardar(50);
cofre.Guardar(-10);
cofre.Guardar(30);

if (cofre.Retirar(100))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

if (cofre.Retirar(20))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

Console.WriteLine($"Saldo: R$ {cofre.Saldo:F2}");
Console.WriteLine($"Faltam R$ {cofre.FaltaParaMeta(200):F2} para a meta.");