using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Shared.Entities
{
    [KnownType(typeof(FullTimeEmployee))]
    [KnownType(typeof(PartTimeEmployee))]
    public abstract class Employee
    {
        [Key]
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
    }
}
