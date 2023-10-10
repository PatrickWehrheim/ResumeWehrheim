using ResumeWehrheim.Companies;
using ResumeWehrheim.Models;
using ResumeWehrheim.Schools;
using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ResumeWehrheim.Pages
{
    /// <summary>
    /// Interaktionslogik für Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        NavigationService _navigationService;
        public Home()
        {
            InitializeComponent();
            InitializeData();

            _navigationService = NavigationService.GetNavigationService(this);
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
                    spezialization: "Games Programming",
                    startTime: new DateTime(2022, 3, 1),
                    endTime: new DateTime(2024, 3, 1),
                    degree: "Diploma in Games Programming and Bachlor of Science")
            );

            AboutMe.Text = "About Me: \n" +
                 "I developed logistic software in WPF and PowerBuilder " +
                 "in my apprenticeship. \n" +
                 "In my studies I learnd a lot about game development in Unity " +
                 "and Unreal Engine. I specialized myself on Game AI. \n" +
                 "I love to bring Characters to life without having a human " +
                 "controlling them.";
        }

        public void OnSchoolClick(object sender, EventArgs e)
        {
            _navigationService.Navigate(new Pages.Schools());
        }

        public void OnCompanieClick(object sender, EventArgs e)
        {
            _navigationService.Navigate(new Pages.Companies());
        }
    }
}
