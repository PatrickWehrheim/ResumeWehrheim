using ResumeWehrheim.Models;
using System;

namespace ResumeWehrheim.Companies
{
    internal class DbhLogistics : Work
    {
        public DbhLogistics(string companyName, string city, string workingTitle, DateTime startTime, DateTime endTime)
            : base(companyName, city, workingTitle, startTime, endTime)
        {
        }
    }
}
