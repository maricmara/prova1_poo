Console.WriteLine("Qual a sua idade?");
int num = int.Parse(Console.ReadLine());




if ( num > 18){
Console.WriteLine($"Você já pode votar e dirigir");
}




else if (num == 18){
Console.WriteLine($"Você já pode votar e dirigir");
}




else{
Console.WriteLine($"Você não pode votar e dirigir");
}

