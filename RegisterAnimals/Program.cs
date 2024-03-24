// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

var animalRepository = new AnimalSqlRepository<Animal>(new RegisterAnimals.Data.AnimalDbContext());

string animalInput = string.Empty;
do
{
    Console.WriteLine("Which Animal did you see? Press L for a lion and E for an elephant. Press X to exit!");
    animalInput = Console.ReadLine();

    if (animalInput != null && animalInput.ToLower() == "e")
    {
        animalRepository.AddAnimal(new Elephant() { Id = Guid.NewGuid()});
    }
    else if (animalInput != null && animalInput == "l")
    {
        animalRepository.AddAnimal(new Lion() { Id = Guid.NewGuid() });
    }
    else if (animalInput != null && animalInput == "x")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Please type an E for Elephant or an L for Lion");
    }
}
while (animalInput.ToLower() != "x");

OutputAnimalCounts(animalRepository);

void OutputAnimalCounts(AnimalSqlRepository<Animal> animalRepository)
{
    Console.WriteLine($"Number of Lions: {animalRepository.GetLionCount()}");
    Console.WriteLine($"Number of Elephants: {animalRepository.GetElephantCount()}");
}





