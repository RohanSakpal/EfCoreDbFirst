using System;
using System.Collections.Generic;

namespace EfCoreDbFirst.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
    }
}
