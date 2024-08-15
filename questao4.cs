Console.WriteLine("Digite um número");
int num = int.Parse(Console.ReadLine());


if ( num < 0){
Console.WriteLine($"Esse número é negativo");
}


else if (num > 0){
Console.WriteLine($"Esse número é positivo");
}


else{
Console.WriteLine($"Esse número é igual a zero");
}
