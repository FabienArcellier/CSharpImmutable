using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public interface IStack<T> : IEnumerable<T>
    {
        IStack<T> Push(T value);
        IStack<T> Pop();
        T Peek();
        bool IsEmpty { get; }
    }
}
