using System;
using Tamarack.Pipeline;

namespace Demo.Pipeline.CommandUI
{
    public class PatientHandler : IFilter<Context, Context>
    {        
        public Context Execute(Context context, Func<Context, Context> executeNext)
        {
            var patient = new Patient
                {
                    FirstName = context.Source.PatientFirstName,
                    Id = context.Source.PatientId,
                    LastName = context.Source.PatientLastName
                };
            context.Destination.Patient = patient;

            return executeNext(context);
        }
    }
}