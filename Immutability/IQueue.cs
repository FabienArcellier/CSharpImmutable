using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public interface IQueue<T> : IEnumerable<T>
    {
        bool IsEmpty { get; }
        T Peek();
        IQueue<T> Enqueue(T value);
        IQueue<T> Dequeue();
    }
}
