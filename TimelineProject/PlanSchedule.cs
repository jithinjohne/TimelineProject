using System;
using System.Collections.Generic;

namespace TimelineProject
{
    public class PlanSchedule
    {
        public PlanSchedule()
        {
            DraftMonths = new List<DraftMonth>
            {
                DraftMonth.January,
                DraftMonth.August,
                DraftMonth.December
            };

            PlanStartDate = new DateTime(2017, 12, 1);
            PlanEndDate = new DateTime(2019, 12, 18);
        }

        public IList<DraftMonth> DraftMonths { get; }

        public DateTime PlanStartDate { get; }

        public DateTime PlanEndDate { get; }
    }
}
