using System.Collections;
using System.Collections.Generic;

namespace ConwaysGameOfLife.Abstracts
{
    public abstract class Universe : IEnumerable<Cell>
    {
        protected Universe()
        {

        }

        public abstract int GetLength(int dimension);

        public abstract IEnumerator<Cell> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
