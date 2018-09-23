using Rules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules
{
    public class RulesChain
    {
        public RulesChain(IRule mainRule, bool isLastInChain = false)
        {
            IsLastInChain = isLastInChain;
            ElseRules = new List<RulesChain>();
            Rule = mainRule;
        }

        public IRule Rule { get; set; }

        public List<RulesChain> ElseRules { get; set; }

        public bool IsLastInChain { get; set; }
    }
}
