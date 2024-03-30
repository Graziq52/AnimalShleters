using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelters
{
    public interface IAnimal
    {
        string Vid { get; set; }
        int Age { get; set; }
        string Name { get; set; }

        void DisplayInfo();
    }
}
