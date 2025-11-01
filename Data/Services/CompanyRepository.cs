using Data.Models;

namespace Data.Services;

// Repository Pattern:
// Concrete repository for "Company" with custom logic
public class CompanyRepository : BaseRepository<Company>
{
    public override void Add(Company company)
    {
        // Custom behavior example
        company.Description = $"Registered company: {company.Name}";
        base.Add(company);
    }
}
