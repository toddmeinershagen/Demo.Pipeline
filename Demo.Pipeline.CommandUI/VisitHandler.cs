using System;
using Tamarack.Pipeline;

namespace Demo.Pipeline.CommandUI
{
    public class VisitHandler : IFilter<Context, Context>
    {
        public Context Execute(Context context, Func<Context, Context> executeNext)
        {
            context.Destination = new Visit
                {
                    EndDate = context.Source.VisitEndDate,
                    StartDate = context.Source.VisitStartDate,
                    Id = context.Source.VisitId
                };

            return executeNext(context);
        }
    }
}