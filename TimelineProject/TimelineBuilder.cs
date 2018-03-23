using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimelineProject
{
    public class TimelineBuilder
    {
        private PlanSchedule _planSchedule;

        public TimelineBuilder()
        {
            _planSchedule = new PlanSchedule();
        }

        public void BuildTimeLine()
        {
            var today = DateTime.Today;
            var oneYearFromToday = today.AddMonths(12);

            var planStartDate = _planSchedule.PlanStartDate;
            var planEndDate = _planSchedule.PlanEndDate;

            var timelineStartDate = planStartDate > today ? planStartDate : today;
            var timelineEndDate = oneYearFromToday > planEndDate ? planEndDate : oneYearFromToday;

            var draftMonths = _planSchedule.DraftMonths.Select(x => (int)x).OrderBy(x => x);
            var timelineDraftMonths = new List<DateTime>();
            for (var timelineCurrentPosition = timelineStartDate; timelineCurrentPosition < timelineEndDate; timelineCurrentPosition = timelineCurrentPosition.AddMonths(1))
            {
                if (draftMonths.Contains(timelineCurrentPosition.Month))
                {
                    timelineDraftMonths.Add(timelineCurrentPosition);
                }
            }

            //Skips
            var planHoldings = _planSchedule.PlanHoldings;
            var planHoldingsCount = planHoldings.Count;
            foreach (var month in timelineDraftMonths)
            {
                var skips = planHoldings.Where(x => x.SkipMonths.Contains((DraftMonth)month.Month));
                var skipCount = skips.Count();
                if (skipCount > 0)
                {
                    if (skipCount == planHoldingsCount)
                    {
                        //Full skip
                    }
                    else
                    {
                        //Partial skip
                        var partialSkipHoldings = skips.Select(x => x.Name);
                    }
                    
                }
            }

        }
    }
}
