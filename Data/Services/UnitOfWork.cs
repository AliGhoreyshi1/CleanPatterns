using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services;

// Coordinates multiple repositories under a single
// transactional boundary (conceptually).
//
// Purpose:
//   - Acts as a central point to manage multiple repositories.
//   - Ensures that all related operations are treated as a single unit of work.
//   - Promotes consistency and reduces data access duplication.
//
// Key Idea:
//   Instead of interacting with repositories separately,
//   the Unit of Work provides a unified entry point to manage them together.
//
// Design Pattern:
//   Unit of Work Pattern — maintains a list of affected objects
//   and coordinates the writing out of changes as one logical operation.
//
// In This Demo:
//   - Operates in memory (no actual database).
//   - Demonstrates the concept without real transactions.
public class UnitOfWork
{
    public CompanyRepository Companies { get; }
    public ChainRepository Chains { get; }
    public UserRepository Users { get; }

    public UnitOfWork()
    {
        Companies = new CompanyRepository();
        Chains = new ChainRepository();
        Users = new UserRepository();
    }

    public void Save()
    {
        // In a real EF project, this would call context.SaveChanges()
        Console.WriteLine("All changes saved successfully (simulated).");
    }
}
