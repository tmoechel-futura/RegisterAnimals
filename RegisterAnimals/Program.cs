// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

// understand object assignment
Animal animal = new Zebra();  // OK  a Zebra is animal

// Zebra zebra = new Animal();  // NOT OK not every animal is a Zebra, so an Animal is not generally a Zebra



// understand Covariance
ICage<Animal> animalCage = new Cage<Animal>();  // OK Interface Types are non varian


ICage<Animal> lionCage = new Cage<Lion>();  // OK if Interface Defintion for T is Covariant

//IPushCage<Lion> lionCage = new Cage<Lion>();  // OK


Lion lion = new Lion() { Name = "Lion"};
Zebra zebra = new Zebra() { Name = "Zebra" };

lionCage.AddAnimal(zebra);
lionCage.AddAnimal(lion);

var firstAnimal = lionCage.GetFirstAnimalInCage();

Console.WriteLine(firstAnimal.Name);


