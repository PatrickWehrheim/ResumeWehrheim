
using System;

namespace ResumeWehrheim.Models
{
    internal class Work
    {
        string CompanyName { get; set; }
        string City { get; set; }
        string WorkingTitle { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }

        public Work(string companyName, string city, string workingTitle, DateTime startTime, DateTime endTime)
        {
            CompanyName = companyName;
            City = city;
            WorkingTitle = workingTitle;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
