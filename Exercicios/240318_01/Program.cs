using _240318_01.Models; //obj:objetos

// instancia de obj do tipo Customer
Customer c1 = new Customer();
//atribuindo valores do obj c1
c1.CustomerId = 1;
c1.FirstName = "Bianca";
c1.LastName = "Maccarini";
c1.BirthDate = new DateTime();
c1.EmailAddress = "bianca.maccarini@gmail.com";

///intancia do obj Address
Address Address1 = new Address();
//atribuindo valor aos atributos do obj Address
Address1.AddressId = 1;
Address1.Street = "Henrique sebbem";
Address1.District = "Amarante";
Address1.City = "videira";
Address1.Number = 980;
Address1.FederalState = "SC";
Address1.Country = "Brasil";
Address1.Zipcode = "89566-492";
//Addresstypr e do tipo 
Address1.AddressType = AddressType.Commercial;

c1.Addresses.Add(Address1);

Console.WriteLine("endereços:");
//
foreach(var ad in c1.Addresses)

{
    Console.WriteLine("----------------");
    Console.WriteLine($"rua: {ad.Street}");
    Console.WriteLine($"Bairro: {ad.District}");
    Console.WriteLine($"numero: {ad.Number}");
    Console.WriteLine($"Cidade: {ad.City}");
    Console.WriteLine($"Estado: {ad.FederalState}");
    Console.WriteLine($"Pais: {ad.Country}");
}
Console.WriteLine($"Nome: {c1.FirstName} {c1.LastName}" );
Console.WriteLine($"email:{c1.EmailAddress}");