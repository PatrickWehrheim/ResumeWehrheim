using System;
using System.Windows;
using ResumeWehrheim.Models;
using ResumeWehrheim.Schools;
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
                    startTime: new DateTime(2015, 8, 1),
                    endTime: new DateTime(2018, 8, 1),
                    degree: "Fachabitur (Computer science)")
            );
            Experience.Companies.Add(
                new DbhLogistics(
                    companyName: "dbh Logistics IT AG",
                    city: "Bremen",
                    workingTitle: "Apprenticeship as Fachinformatiker für " +
                    "Anwendungsentwicklung",
                    startTime: new DateTime(2018, 8, 1),
                    endTime: new DateTime(2021, 8, 1)
                )
            );
            Experience.Companies.Add(
                new SIXT(
                    companyName: "SIXT Autovermietung",
                    city: "Bremen",
                    workingTitle: "Driver",
                    startTime: new DateTime(2021, 8, 1),
                    endTime: new DateTime(2022, 3, 1)
                )
            );
            Education.Schools.Add(
                new SAEHannover(
                    schoolName: "SAE Institute Hannover",
                    spezialization: "Computer science",
                    startTime: new DateTime(2022, 3, 1),
                    endTime: new DateTime(2024, 3, 1),
                    degree: "Diploma in Games Programming and Bachlor of Science")
            );
        }
    }
}
