using System;

namespace Demo.Pipeline.CommandUI
{
    public struct Source
    {
        public int VisitId { get; set; }
        public DateTime VisitStartDate { get; set; }
        public DateTime VisitEndDate { get; set; }

        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
    }
}