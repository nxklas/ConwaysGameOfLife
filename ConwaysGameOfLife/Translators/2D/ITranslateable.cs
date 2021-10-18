using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife.Translators
{
    public interface ITranslateable
    {
        protected void Translate(Frame frame);
    }
}
