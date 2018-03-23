using System;
using System.Collections.Generic;
using TimelineProject;

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

            PlanHoldings = new List<PlanHolding>
            {
                new PlanHolding
                {
                    Name = "Google",
                    SkipMonths = new List<DraftMonth>
                                    {
                                        DraftMonth.January
                                    }
                },

                                new PlanHolding
                {
                    Name = "Tesla",
                    SkipMonths = new List<DraftMonth>
                                    {
                                        DraftMonth.January,
                                        DraftMonth.August
                                    }
                }
            };
        }

        public IList<PlanHolding> PlanHoldings { get; }

        public IList<DraftMonth> DraftMonths { get; }

        public DateTime PlanStartDate { get; }

        public DateTime PlanEndDate { get; }
    }
}
