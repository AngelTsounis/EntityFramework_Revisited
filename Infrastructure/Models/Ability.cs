using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models;

public class Ability
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int Power { get; set; } 
    public int Accuracy { get; set; }
    public int TypeId { get; set; }
    public ElementType? Type { get; set; } = null!;
}


