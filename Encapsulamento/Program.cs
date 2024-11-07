Conta cont = new Conta();
Console.WriteLine("Digite o valor que queres depositar:");
double ss = double.Parse(Console.ReadLine());

cont.SetSaldo(ss);

Console.WriteLine(cont.GetSaldo());