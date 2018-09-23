using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Interfaces
{
    public interface IRuleResult
    {
        bool IsSuccess { get; set; }

        void Execute();
    }
}
