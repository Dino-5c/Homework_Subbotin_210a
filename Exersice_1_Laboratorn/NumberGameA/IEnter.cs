using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGameA
{
    public interface IEnter
    {
        int UserNumberEntering();

        Level MakeLevelChoose();
    }
}
