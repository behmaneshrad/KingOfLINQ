using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfLINQ.Helper
{
    public class PetByTypeComparer : IComparer<Pet>
    {
        int IComparer<Pet>.Compare(Pet? x, Pet? y)
        {
            return x.PetType.CompareTo(y.PetType);
        }
    }
}
