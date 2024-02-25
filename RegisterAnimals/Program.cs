﻿// See https://aka.ms/new-console-template for more information
using RegisterAnimals.Entities;
using RegisterAnimals.Repositories;

Console.WriteLine("Welcome to the Animal Registration App!");

var animalRepository = new AnimalRepository<Animal> ();
string animalInput = string.Empty;
do
{
    Console.WriteLine("Which Animal did you see? Press L for a lion and E for an elefant. Press X to exit!");
    animalInput = Console.ReadLine();

    if (animalInput != null && animalInput.ToLower() == "e")
    {
        animalRepository.AddAnimal(new Elefant() { Id = Guid.NewGuid()});
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
        Console.WriteLine("Please type an E for Elefant or an L for Lion");
    }
}
while (animalInput.ToLower() != "x");

Console.WriteLine($"Number of Lions: {animalRepository.GetLionCount()}");
Console.WriteLine($"Number of Elefants: {animalRepository.GetElefantCount()}");




