Console.WriteLine("Digite seu primeiro Nome:");
string nome = Console.ReadLine()!;
Console.WriteLine("Digite seu sobrenome:");
string sobrenome = Console.ReadLine()!;

Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de Catálogo: {sobrenome.ToUpper()}, {nome}");


