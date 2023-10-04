
using System;

namespace ResumeWehrheim.Models
{
    internal class School
    {
        string SchoolName { get; set; }
        string City { get; set; }
        string Spezialization { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        string Degree { get; set; }

        public School(string schoolName, string spezialization, DateTime startTime, DateTime endTime, string degree, string city = "")
        {
            SchoolName = schoolName;
            City = city;
            Spezialization = spezialization;
            StartTime = startTime;
            EndTime = endTime;
            Degree = degree;
        }
    }
}
