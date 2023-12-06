using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfLINQ.Helper
{
    public class PetComparerById : IEqualityComparer<Pet>
    {
        bool IEqualityComparer<Pet>.Equals(Pet? x, Pet? y)
        {
            return x.Id == y.Id;
        }

        int IEqualityComparer<Pet>.GetHashCode([DisallowNull]Pet obj)
        {
            return obj.Id;
        }
    }
}
