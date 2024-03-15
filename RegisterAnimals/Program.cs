///
/// In this example we create a generic animal cage into which we can put Lions and Zebras - not a good idea though ;-)
/// We first add one Zebra and then one Lion and show the first animal in the cage which is a Zebra 
///

// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

/// *** Importanct concept to understand *** /
// understand object assignment
Animal animal = new Zebra();  // OK  a Zebra is animal

// Zebra zebra = new Animal();  // NOT OK not every animal is a Zebra, so an Animal is not generally a Zebra
/// ****************************************** //
/// 

// I want to put animal into a Cage<T> #
// OK Interface Types are invariant -> means the generic type interface must be the same type as the type 
// of the created class here new Cage<Animal>();
ICage<Animal> animalCage = new Cage<Animal>();  


// ICage<Animal> cage = new Cage<Zebra>();  // not OK Interface Types are different 


Lion lion = new Lion() { Name = "Lion"};
Zebra zebra = new Zebra() { Name = "Zebra" };

animalCage.AddAnimal(zebra);
animalCage.AddAnimal(lion);

var firstAnimal = animalCage.GetFirstAnimalInCage();

Console.WriteLine(firstAnimal.Name);


