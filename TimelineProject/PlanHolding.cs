using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimelineProject
{
    public class PlanHolding
    {
        public string Name { get; set; }

        public IList<DraftMonth> SkipMonths { get; set; }
    }
}
