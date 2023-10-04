using ResumeWehrheim.Models;
using System;

namespace ResumeWehrheim.Schools
{
    internal class SAEHannover : School
    {
        public SAEHannover(string schoolName, string spezialization, DateTime startTime, DateTime endTime, string degree, string city = "Hannover")
            : base(schoolName, spezialization, startTime, endTime, degree, city)
        {
        }
    }
}
