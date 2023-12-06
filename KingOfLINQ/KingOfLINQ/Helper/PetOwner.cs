using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfLINQ.Helper
{
    public class PetOwner
    {
        public string FullName { get; set; }
        public int PetId { get; set; }

        public PetOwner(string fullname,int petId)
        {
            FullName = fullname;
            PetId = petId;
        }

        public override string ToString()
        {
            return $"FullName: {FullName}, PetId: {PetId}";
        }
    }
}
