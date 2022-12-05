using Model;

using var context = new Context();

context.Database.EnsureCreated();


context.Concessionaria.Add(new Concessionaria{
    nome = "Atena concessionária"
});
context.Concessionaria.Add(new Concessionaria{
    nome = "Demétir concessionária"
});
context.Concessionaria.Add(new Concessionaria{
    nome = "Hera concessionária"
});
context.Concessionaria.Add(new Concessionaria{
    nome = "Estia concessionária"
});
context.Concessionaria.Add(new Concessionaria{
    nome = "Perséfone concessionária"
});


context.Automoveis.Add(new Automoveis{
    modelo = "Fiat Strada",
    valor = 43115
});
context.Automoveis.Add(new Automoveis{
    modelo = "Fiat Argo",
    valor = 47660
});
context.Automoveis.Add(new Automoveis{
    modelo = "Fiat Mobi",
    valor = 32102
});
context.Automoveis.Add(new Automoveis{
    modelo = "Jeep Compass",
    valor = 34950
});
context.Automoveis.Add(new Automoveis{
    modelo = "Hyundai HB20",
    valor = 49302
});
context.Automoveis.Add(new Automoveis{
    modelo = "Jeep Renegade",
    valor = 36661
});
context.Automoveis.Add(new Automoveis{
    modelo = "Volkswagen T-Cross",
    valor = 38182
});
context.Automoveis.Add(new Automoveis{
    modelo = "Fiat Toro",
    valor = 57733
});
context.Automoveis.Add(new Automoveis{
    modelo = "Hyundai Creta",
    valor = 55998
});
context.Automoveis.Add(new Automoveis{
    modelo = "Chevrolet S10",
    valor = 51035
});
context.Automoveis.Add(new Automoveis{
    modelo = "Toyota Corolla Cross",
    valor = 34544
});
context.Automoveis.Add(new Automoveis{
    modelo = "Toyota Hilux",
    valor = 53937
});
context.Automoveis.Add(new Automoveis{
    modelo = "Toyota Corolla",
    valor = 55022
});
context.Automoveis.Add(new Automoveis{
    modelo = "Volkswagen Gol",
    valor = 48253
});
context.Automoveis.Add(new Automoveis{
    modelo = "Honda HR-V",
    valor = 53438
});
context.Automoveis.Add(new Automoveis{
    modelo = "Renault Kwid",
    valor = 31810
});
context.Automoveis.Add(new Automoveis{
    modelo = "Volkswagen Nivus",
    valor = 35104
});
context.Automoveis.Add(new Automoveis{
    modelo = "Hyundai HB20S",
    valor = 31855
});
context.Automoveis.Add(new Automoveis{
    modelo = "Ford Ranger",
    valor = 48927
});
context.Automoveis.Add(new Automoveis{
    modelo = "Fiat Uno",
    valor = 38111
});
context.Automoveis.Add(new Automoveis{
    modelo = "Fiat Cronos",
    valor = 36515
});
context.Automoveis.Add(new Automoveis{
    modelo = "Citroën C4 Cactus",
    valor = 53654
});
context.Automoveis.Add(new Automoveis{
    modelo = "Toyota Yaris Hatchback",
    valor = 55869
});
context.Automoveis.Add(new Automoveis{
    modelo = "Volkswagen Voyage",
    valor = 30954
});
context.Automoveis.Add(new Automoveis{
    modelo = "Honda Civic",
    valor = 30871
});
context.Automoveis.Add(new Automoveis{
    modelo = "Volkswagen Saveiro",
    valor = 32306
});
context.Automoveis.Add(new Automoveis{
    modelo = "Caoa Chery Tiggo 5x",
    valor = 30069
});
context.Automoveis.Add(new Automoveis{
    modelo = "Volkswagen Virtus",
    valor = 40689
});
context.Automoveis.Add(new Automoveis{
    modelo = "Fiat Grand Siena",
    valor = 33469
});
context.Automoveis.Add(new Automoveis{
    modelo = "Caoa Chery Tiggo 8",
    valor = 48481
});
context.Automoveis.Add(new Automoveis{
    modelo = "Chevrolet Tracker",
    valor = 30648
});
context.Automoveis.Add(new Automoveis{
    modelo = "Peugeot 208",
    valor = 46934
});
context.Automoveis.Add(new Automoveis{
    modelo = "Toyota SW4",
    valor = 54252
});
context.Automoveis.Add(new Automoveis{
    modelo = "Nissan Frontier",
    valor = 32596
});
context.Automoveis.Add(new Automoveis{
    modelo = "Honda WR-V",
    valor = 35139
});
context.Automoveis.Add(new Automoveis{
    modelo = "Volkswagen Taos",
    valor = 47546
});
context.Automoveis.Add(new Automoveis{
    modelo = "Mitsubishi L200",
    valor = 57049
});
context.Automoveis.Add(new Automoveis{
    modelo = "Renault Oroch",
    valor = 48756
});
context.Automoveis.Add(new Automoveis{
    modelo = "Toyota Yaris Sedan",
    valor = 43077
});
context.Automoveis.Add(new Automoveis{
    modelo = "Renault Duster",
    valor = 52641
});


context.Cliente.Add(new Cliente{
    nome = "Adalberto Martins da Silva"
});
context.Cliente.Add(new Cliente{
    nome = "Adan Roger Guimarães Dias"
});
context.Cliente.Add(new Cliente{
    nome = "Adão Walter Gomes de Sousa"
});
context.Cliente.Add(new Cliente{
    nome = "Adelson Fernandes Sena"
});
context.Cliente.Add(new Cliente{
    nome = "Ademir Augusto Simões"
});
context.Cliente.Add(new Cliente{
    nome = "Ademir Borges dos Santos"
});
context.Cliente.Add(new Cliente{
    nome = "Adilio José da Silva Santos"
});
context.Cliente.Add(new Cliente{
    nome = "Adriana Ferreira de Lima Teodoro"
});
context.Cliente.Add(new Cliente{
    nome = "Adriano Bezerra Apolinario"
});
context.Cliente.Add(new Cliente{
    nome = "Adriano Heleno Basso"
});
context.Cliente.Add(new Cliente{
    nome = "Adriano Lourenço do Rego"
});
context.Cliente.Add(new Cliente{
    nome = "Adriano Matos Santos"
});
context.Cliente.Add(new Cliente{
    nome = "Adriano Pires Caetano"
});
context.Cliente.Add(new Cliente{
    nome = "Adriano Prada de Campos"
});
context.Cliente.Add(new Cliente{
    nome = "Adriel Alberto dos Santos"
});
context.Cliente.Add(new Cliente{
    nome = "Agner Vinicius Marques de Camargo"
});
context.Cliente.Add(new Cliente{
    nome = "Agrinaldo Ferreira Soares"
});
context.Cliente.Add(new Cliente{
    nome = "Alan Jhonnes Banlian da Silva e Sá"
});
context.Cliente.Add(new Cliente{
    nome = "Alberto Ramos Rodrigues"
});
context.Cliente.Add(new Cliente{
    nome = "Alcides José Ramos"
});
context.Cliente.Add(new Cliente{
    nome = "Aldemir SantAna dos Santos"
});
context.Cliente.Add(new Cliente{
    nome = "Aleksandro Marcelo da Silva"
});
context.Cliente.Add(new Cliente{
    nome = "Alessandro Martins Silva"
});
context.Cliente.Add(new Cliente{
    nome = "Alessandro Sanches"
});
context.Cliente.Add(new Cliente{
    nome = "Alex dos Reis de Jesus"
});
context.Cliente.Add(new Cliente{
    nome = "Alex Ferreira Soares"
});
context.Cliente.Add(new Cliente{
    nome = "Alex Sandro Oliveira"
});
context.Cliente.Add(new Cliente{
    nome = "Alex Souza Farias"
});
context.Cliente.Add(new Cliente{
    nome = "Alexandra de Lima Silva"
});
context.Cliente.Add(new Cliente{
    nome = "Alexandre Clemente da Costa"
});


context.Alocacao.Add(new Alocacao{
    area = 1, 
    automoveisId = 1,
    concessionariaId = 1,
    quantidade = 8,
});
context.Alocacao.Add(new Alocacao{
    area = 2, 
    automoveisId = 2,
    concessionariaId = 2,
    quantidade = 1,
});
context.Alocacao.Add(new Alocacao{
    area = 4, 
    automoveisId = 3,
    concessionariaId = 3,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 7, 
    automoveisId = 4,
    concessionariaId = 4,
    quantidade = 6,
});
context.Alocacao.Add(new Alocacao{
    area = 8, 
    automoveisId = 5,
    concessionariaId = 5,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 9, 
    automoveisId = 6,
    concessionariaId = 1,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 10, 
    automoveisId = 7,
    concessionariaId = 2,
    quantidade = 1,
});
context.Alocacao.Add(new Alocacao{
    area = 1, 
    automoveisId = 8,
    concessionariaId = 2,
    quantidade = 7,
});
context.Alocacao.Add(new Alocacao{
    area = 2, 
    automoveisId = 9,
    concessionariaId = 3,
    quantidade = 2,
});
context.Alocacao.Add(new Alocacao{
    area = 4, 
    automoveisId = 10,
    concessionariaId = 4,
    quantidade = 6,
});
context.Alocacao.Add(new Alocacao{
    area = 7, 
    automoveisId = 11,
    concessionariaId = 5,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 8, 
    automoveisId = 12,
    concessionariaId = 1,
    quantidade = 9,
});
context.Alocacao.Add(new Alocacao{
    area = 9, 
    automoveisId = 13,
    concessionariaId = 2,
    quantidade = 9,
});
context.Alocacao.Add(new Alocacao{
    area = 10, 
    automoveisId = 14,
    concessionariaId = 3,
    quantidade = 6,
});
context.Alocacao.Add(new Alocacao{
    area = 1, 
    automoveisId = 15,
    concessionariaId = 3,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 2, 
    automoveisId = 16,
    concessionariaId = 4,
    quantidade = 1,
});
context.Alocacao.Add(new Alocacao{
    area = 4, 
    automoveisId = 17,
    concessionariaId = 5,
    quantidade = 8,
});
context.Alocacao.Add(new Alocacao{
    area = 7, 
    automoveisId = 18,
    concessionariaId = 1,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 8, 
    automoveisId = 19,
    concessionariaId = 2,
    quantidade = 10,
});
context.Alocacao.Add(new Alocacao{
    area = 9, 
    automoveisId = 20,
    concessionariaId = 3,
    quantidade = 10,
});
context.Alocacao.Add(new Alocacao{
    area = 10, 
    automoveisId = 21,
    concessionariaId = 4,
    quantidade = 7,
});
context.Alocacao.Add(new Alocacao{
    area = 1, 
    automoveisId = 22,
    concessionariaId = 4,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 2, 
    automoveisId = 23,
    concessionariaId = 5,
    quantidade = 5,
});
context.Alocacao.Add(new Alocacao{
    area = 4, 
    automoveisId = 24,
    concessionariaId = 1,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 7, 
    automoveisId = 25,
    concessionariaId = 2,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 8, 
    automoveisId = 26,
    concessionariaId = 3,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 7, 
    automoveisId = 27,
    concessionariaId = 4,
    quantidade = 10,
});
context.Alocacao.Add(new Alocacao{
    area = 10, 
    automoveisId = 28,
    concessionariaId = 5,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 1, 
    automoveisId = 29,
    concessionariaId = 1,
    quantidade = 2,
});
context.Alocacao.Add(new Alocacao{
    area = 2, 
    automoveisId = 30,
    concessionariaId = 2,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 4, 
    automoveisId = 31,
    concessionariaId = 3,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 7, 
    automoveisId = 32,
    concessionariaId = 3,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 8, 
    automoveisId = 33,
    concessionariaId = 5,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 9, 
    automoveisId = 34,
    concessionariaId = 1,
    quantidade = 4,
});
context.Alocacao.Add(new Alocacao{
    area = 10, 
    automoveisId = 35,
    concessionariaId = 2,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 1, 
    automoveisId = 36,
    concessionariaId = 3,
    quantidade = 2,
});
context.Alocacao.Add(new Alocacao{
    area = 2, 
    automoveisId = 37,
    concessionariaId = 4,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 4, 
    automoveisId = 38,
    concessionariaId = 5,
    quantidade = 3,
});
context.Alocacao.Add(new Alocacao{
    area = 7, 
    automoveisId = 39,
    concessionariaId = 1,
    quantidade = 2,
});
context.Alocacao.Add(new Alocacao{
    area = 8, 
    automoveisId = 40,
    concessionariaId = 2,
    quantidade = 1,
});

context.SaveChanges();


