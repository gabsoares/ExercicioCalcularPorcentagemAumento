double salarioInicial = 2, salarioFinal = 1, porcentagemAumento = 0, aumento = 0;

while (salarioInicial > salarioFinal)
{
    Console.Write("Digite o valor do salário: ");
    salarioInicial = double.Parse(Console.ReadLine());

    Console.Write("Digite o valor do salário com acréscimo (não pode ser valor menor que o salário inicial): ");
    salarioFinal = double.Parse(Console.ReadLine());

    aumento = salarioFinal - salarioInicial;

    porcentagemAumento = aumento * 100 / salarioInicial;
}

Console.WriteLine($"O aumento foi de {porcentagemAumento}%");
