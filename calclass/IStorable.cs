using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calclass
{
    public interface IStorable
    {
        void SaveState(string fileName);
        void LoadState(string fileName);
    }
}
