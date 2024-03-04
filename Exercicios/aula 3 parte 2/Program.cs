//subistituindo conteudo de string
string nomeCompleto = "Bianca Maccarini"
nomeCompleto = nomeCompleto.Replace("Maccarini", "sla");
Console.WriteLine(nomeCompleto);

//comparacao de strings
boll isNomeEqual = (nomeCompleto == "Bianca Maccarini");

bool isNomeEqual2 = string.Eqquals(nomeCompleto, "Bianca sla");

Console.WriteLine($"primeiro resultado: {isNomeEqual}");
Console.WriteLine($"segundo resultado: {isNomeEqual2}");