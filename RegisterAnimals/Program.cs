///
/// In this example we want to create 2 generic animal cages into which we can put either Lions or Zebras - so they will not eat each other ;-)
/// 
///

// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

// I create a cage for Lions
// OK if Interface Types are covariant because I use a more specific type (Lion) to be used as the generic Type 
// But a covariant interface can only access the value which means you can read data, but you can not add data
// This makes sense because you do not want to add a Zebra into a Lions Cage (in general you do not want to be able to add another specific type)
// The interface definition now contains the out keyword: public interface ICage<out T> where T : Animal
ICage<Animal> cage = new Cage<Lion>();  

Lion simba = new Lion() { Name = "Simba"};
Lion Johny = new Lion() { Name = "Johny" };

// If I want to be able to add a lion (receive a more spefic type as an argument)
// I must currently provide a method in my interface to add explicitly Lions, I created a method AddLion for this purpose
// but this is not so nice as I would also need a method for adding Zebras
cage.AddLion(simba);
cage.AddLion(Johny);

var firstAnimal = cage.GetFirstAnimalInCage();

Console.WriteLine(firstAnimal.Name);


