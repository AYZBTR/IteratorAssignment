using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositeExercise.InterfaceIterator
{
    // Interface representing an iterator
    public interface IIterator
    {
        // Method to check if there is a next element
        bool HasNext();

        // Method to get the next element
        object Next();
    }
}
