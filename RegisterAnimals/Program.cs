///
/// In this example we want to create 2 generic animal cages into which we can put either Lions or Zebras - so they will not eat each other ;-)
/// 
///

// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

// I create a cage for Lions
ICage<Animal> animalCage = new Cage<Animal>();  // OK Interface Types are non variant

// This does not work, if I create a Zebra cage I can not put any animals inside  
// ICage<Animal> animalCage = new Cage<Zebra>();  // OK Interface Types are non variant


Lion lion = new Lion() { Name = "Lion"};
Zebra zebra = new Zebra() { Name = "Zebra" };

animalCage.AddAnimal(zebra);
animalCage.AddAnimal(lion);

var firstAnimal = animalCage.GetFirstAnimalInCage();

Console.WriteLine(firstAnimal.Name);


