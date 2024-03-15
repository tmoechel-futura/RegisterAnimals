///
/// In this example we want to create 2 generic animal cages into which we can put either Lions or Zebras - so they will not eat each other ;-)
/// 
///

// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

// I create a cage for Lions
IReadCage<Animal> cage = new Cage<Lion>();  // OK if IReadCage<T> is covariant

IChangeCage<Lion> lionCage = new Cage<Animal>(); // Now you can pass in a morevar specific type as the generic interface type

Lion simba = new Lion() { Name = "Simba"};
Lion Johny = new Lion() { Name = "Johny" };

// If the interface ICage<T> is covariant and contravariant I can use the AddAnimal method 
// which on an Cage<Lion> will not allow to add Zebras


AddAnimalsToCage(lionCage);
GetFirstAnimalInTheCage(cage);

void AddAnimalsToCage(IChangeCage<Lion> cage)
{
    // those methods will not work if the interface is only covariant
    cage.AddAnimal(simba);
    cage.AddAnimal(Johny);
}


// I want to get the first animal in the cage
// no matter if it is a cage with lions or a cage with zebras
// so the paramter type should be ICage<Animal>
void GetFirstAnimalInTheCage(IReadCage<Animal> cage)
{
    var firstAnimal = cage.GetFirstAnimalInCage();
    Console.WriteLine(firstAnimal.Name);
}







