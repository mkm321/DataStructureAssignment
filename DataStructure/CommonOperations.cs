using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    // This is a common operation interface having methods define who are commonly used in every data structure.
    interface ICommonOperations
    {
        void Add(int data);
        void Remove();
        void Display();
        void Sort();
    }
}
