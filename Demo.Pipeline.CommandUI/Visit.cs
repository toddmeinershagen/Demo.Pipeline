using System;

namespace Demo.Pipeline.CommandUI
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Patient Patient { get; set; }
    }
}