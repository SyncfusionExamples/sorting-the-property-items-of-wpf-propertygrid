using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.ComponentModel.DataAnnotations;
using System.Windows.Media.Imaging;
using System.Reflection;

namespace SortDirectionSample
{
    public class Person
    {
        public Person()
        {
            FirstName = "Carl";
            LastName = "Johnson";
            Age = 30;
            Mobile = 91983467382;
            Email = "carljohnson@gta.com";
            ID = "0005A";
            DOB = new DateTime(1987, 10, 16);
            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Image = new BitmapImage(new Uri(path + @"\carl.png", UriKind.RelativeOrAbsolute));
            Designation = "Team Lead";
        }
        
        [Display(Order = 3)]
        public Gender Gender
        {
            get;

            set;
        }

        [Display(Order = 7)]
        public Country Country
        {
            get;

            set;
        }
       

        [Display(Order = 6)]
        public string Email
        {
            get;

            set;
        }

        [Display(Order = 0)]
        public string FirstName
        {
            get;

            set;
        }
        
        public string Designation
        {
            get;

            set;
        }


        [Display(Order = 1)]
        public string LastName
        {
            get;

            set;
        }

        public string ID
        {
            get;

            set;
        }


        [Display(Order = 4)]
        public DateTime DOB
        {
            get;

            set;
        }


        [Display(Order = 5)]
        public long Mobile
        {
            get;

            set;
        }

        [Display(Order = 2)]
        public int Age
        {
            get;

            set;
        }

        public ImageSource Image
        {
            get;

            set;
        }
    }

    public enum Gender
    {
        Male,

        Female
    }

    public enum Country
    {
        UnitedStates,

        Germany,

        Canada,

        Mexico,

        Alaska,

        Japan,

        China,

        Peru,

        Chile,

        Argentina,

        Brazil
    }
}
