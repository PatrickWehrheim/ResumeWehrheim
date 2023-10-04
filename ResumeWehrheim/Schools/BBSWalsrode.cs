using ResumeWehrheim.Models;
using System;

namespace ResumeWehrheim.Schools
{
    internal class BBSWalsrode : School
    {
        public BBSWalsrode(string schoolName, string spezialization, DateTime startTime, DateTime endTime, string degree, string city = "Walsrode")
            : base(schoolName, spezialization, startTime, endTime, degree, city)
        {
        }
    }
}
