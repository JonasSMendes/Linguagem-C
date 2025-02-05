
Console.WriteLine("Digite seu nome: ");
String nome = Console.ReadLine();

Console.WriteLine("qual o seu peso? ");
Double peso = double.Parse(Console.ReadLine());

Console.WriteLine("sua altura? ");
double altura = double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine("seu nome é " + nome + " e pesa: " + peso + "kl  sua altura é de: " + altura);

Console.WriteLine(nome + " seu Imc é: " + imc);
