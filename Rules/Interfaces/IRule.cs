using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Interfaces
{
    public interface IRule
    {
        IRuleResult Eval();
    }
}
