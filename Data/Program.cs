using Data.Models;
using Data.Services;

var unit = new UnitOfWork();

// Repository Pattern — working with each entity repository
unit.Companies.Add(new Company { Id = 1, Name = "TechBridge" });
unit.Users.Add(new User { Id = 1, Name = "Ali" });
unit.Chains.Add(new Chain { Id = 1, Name = "Chain A" });

// Template Method Pattern — behavior inherited from BaseRepository
unit.Companies.Add(new Company { Id = 2, Name = "Microsoft" });
unit.Companies.Update(new Company { Id = 2, Name = "Microsoft Updated", Description = "Modified!" });

// Unit of Work Pattern — commit all changes together
unit.Save();

// Output all data
Console.WriteLine("\n--- Companies ---");
foreach (var c in unit.Companies.GetAll())
    Console.WriteLine($"{c.Id}: {c.Name} - {c.Description}");

Console.WriteLine("\n--- Users ---");
foreach (var u in unit.Users.GetAll())
    Console.WriteLine($"{u.Id}: {u.Name}");

Console.WriteLine("\n--- Chains ---");
foreach (var ch in unit.Chains.GetAll())
    Console.WriteLine($"{ch.Id}: {ch.Name}");

Console.WriteLine("\n Repository + Template Method + Unit of Work demo complete!");
