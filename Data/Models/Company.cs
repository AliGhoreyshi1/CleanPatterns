using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class Company
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
