using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutability
{
    public class AnimalImmutable
    {
        private readonly double m_size;
        private readonly string m_type;

        public AnimalImmutable(double size, string type)
        {
            this.m_size = size;
            this.m_type = type;
        }

        public double Size
        {
            get
            {
                return this.m_size;
            }
        }

        public AnimalImmutable SetSize(double size)
        {
            return new AnimalImmutable(size, this.m_type);
        }

        public string Type
        {
            get
            {
                return this.m_type;
            }
        }

        public AnimalImmutable SetType(string type)
        {
            return new AnimalImmutable(this.m_size, type);
        }
    }
}
