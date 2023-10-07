using ResumeWehrheim.Models;
using System;

namespace ResumeWehrheim.Companies
{
    internal class SIXT : Work
    {
        public SIXT(string companyName, string city, string workingTitle, DateTime startTime, DateTime endTime) 
            : base(companyName, city, workingTitle, startTime, endTime)
        {
        }
    }
}
