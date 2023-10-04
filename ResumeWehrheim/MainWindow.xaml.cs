using System;
using ResumeWehrheim.Models;
using ResumeWehrheim.Schools;
using System.Windows;
using ResumeWehrheim.Companies;

namespace ResumeWehrheim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            Education.Schools.Add(
                new BBSWalsrode(
                    schoolName: "BBS Walsrode",
                    spezialization: "Computer science",
                    startTime: new DateTime(2001, 1, 1),
                    endTime: new DateTime(2001, 1, 1),
                    degree: "Fachabitur (Computer science)")
            );
            Education.Schools.Add(
                new SAEHannover(
                    schoolName: "SAE Institute Hannover",
                    spezialization: "Computer science",
                    startTime: new DateTime(2001, 1, 1),
                    endTime: new DateTime(2001, 1, 1),
                    degree: "Diploma in Games Programming and Bachlor of Science")
            );
            Experience.Companies.Add(
                new DbhLogistics(
                    companyName: "dbh Logistics IT AG",
                    city: "Bremen",
                    workingTitle: "Apprenticeship as Fachinformatiker für " +
                    "Anwendungsentwicklung",
                    startTime: new DateTime(2001, 1, 1),
                    endTime: new DateTime(2001, 1, 1)
                )
            );
        }
    }
}
