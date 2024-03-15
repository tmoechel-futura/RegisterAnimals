///
/// In this example we want to create 2 generic animal cages into which we can put either Lions or Zebras - so they will not eat each other ;-)
/// 
///

// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

// I create a cage for Lions
// OK if Interface Types are covariant because I use a less specific type (Animal) to be used as the generic Interface Type 
// But a covariant interface can only access the value which means you can read data, but you can not add data
// This makes sense because you do not want to add a Zebra into a Lions Cage (in general you do not want to be able to add another specific type)

// Covariance means that you can use a less specific type (in this case the parent type) as the generic interface type
// You make an interface covariant by defining the out keyword to the type specification

// In a covariant Animal Cage you can read all the animals of the cage but you should not be able to add a differnet specific type
// into the Cage because you would then have different specific types (lions and zebras) in the cage.

ICage<Animal> animalCage = new Cage<Animal>(); // Now you can pass in a morevar specific type as the generic interface type

Lion simba = new Lion() { Name = "Simba"};
Lion Johny = new Lion() { Name = "Johny" };

Zebra sally = new Zebra { Name = "Sally" };

// If the interface ICage<T> is covariant and contravariant I can use the AddAnimal method 
// which on an Cage<Lion> will not allow to add Zebras

AddLionsToCage(animalCage);
GetFirstAnimalInTheCage(animalCage);

// I want to add a specific type of animal to the the cage
void AddLionsToCage(IChangeCage<Lion> cage)  // -> I am passing here a more specific type which works when the interface is contravariant
{
    // those methods will not work if the interface is only covariant
    cage.AddAnimal(simba);
    cage.AddAnimal(Johny);
    //cage.AddAnimal(sally);  // this will not work because the cage is a Lions Cage !
}


// I want to get the first animal in the cage
// no matter if it is a cage with lions or a cage with zebras
void GetFirstAnimalInTheCage(IReadCage<Animal> cage)  // -> I am passing here a less specific type which works when the interface is covariant
{
    var firstAnimal = cage.GetFirstAnimalInCage();
    Console.WriteLine(firstAnimal.Name);
}







