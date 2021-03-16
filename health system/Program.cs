using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamilareHealthProfile
{
    public class HealthProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string MonthOfBirth { get; set; }
        public int DayOfBirth { get; set; }
        public int YearOfBirth { get; set; }
        public int HeightInInches { get; set; }
        public int WeightInPounds { get; set; }
        public int CurrentYear { get; set; }

        public HealthProfile(string firstName, string lastName, string gender, string monthOfBirth, int dayOfBirth, int yearOfBirth, int heightInInches, int weightInPounds, int currentYear)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            MonthOfBirth = monthOfBirth;
            DayOfBirth = dayOfBirth;
            YearOfBirth = yearOfBirth;
            HeightInInches = heightInInches;
            WeightInPounds = weightInPounds;
            CurrentYear = currentYear;
        }
        public void DisplayFirstName()
        {
            Console.WriteLine("First Name: {0}", FirstName);
        }
        public void DisplayLastName()
        {
            Console.WriteLine("Last Name: {0}", LastName);
        }
        public void DisplayGender()
        {
            Console.WriteLine("Gender is: {0}", Gender);
        }
        public void DisplayMonthOfBirth()
        {
            Console.WriteLine("Month of Birth is: {0}", MonthOfBirth);
        }
        public void DisplayDayOfBirth()
        {
            Console.WriteLine("Day of Birth is: {0}", DayOfBirth);
        }
        public void DisplayYearOfBirth()
        {
            Console.WriteLine("Year of Birth is: {0}", YearOfBirth);
        }
        public void DisplayHeightInInches()
        {
            Console.WriteLine("Height is: {0}", HeightInInches);
        }
        public void DisplayWeightInPounds()
        {
            Console.WriteLine("Weight  is: {0}", WeightInPounds);
        }
        public void DisplayCurrentYear()
        {
            Console.WriteLine("Current Year is: {0}", CurrentYear);
        }


        public float BodyMassIndex()
        {
            float BMI = (WeightInPounds * 703) / (HeightInInches * HeightInInches);
            return BMI;
        }
        public void DisplayBodyMassIndex()
        {
            Console.WriteLine("Body Mass Index: {0}", BodyMassIndex());
        }
        public void DisplayBMIOutput()
        {

            if (BodyMassIndex() < 18.5)
            {
                Console.Write("\nDue to your BMI value,You are Underweight.\n");
            }
            else if (BodyMassIndex() < 25)
            {
                Console.Write("\nDue to your BMI value,Your weight is Normal.\n");
            }
            else if (BodyMassIndex() < 30)
            {
                Console.Write("\nDue to your BMI value,You are Overweight\n");
            }
            else Console.Write("\nDue to your BMI value,You are Obese.\n");
        }
        public void DisplayBMIChart()
        {
            Console.Write("\n\n\nBMI Values\n\nUnderweight: less than 18.5\nNormal: between 18.5 and 24.9\nOverweight: between 25 and 29.9\nObese: 30 or greater\n");
        }

        public int Age()
        {
            int Age = (CurrentYear - YearOfBirth);
            return Age;
        }
        public void DisplayAge()
        {
            Console.WriteLine("{0} years of age.", Age());
        }

        public double MaxHeartRate()
        {
            int MaxHeartRate = (220 - Age());
            return MaxHeartRate;
        }
        public void DisplayMaxHeartRate()
        {
            Console.WriteLine("Max heart rate: {0}", MaxHeartRate());
        }


        public double TargetHeartRate()
        {
            double TargetHeartRate = (0.68 * MaxHeartRate());
            // 0.68 is the average of 50%-85%
            return TargetHeartRate;
        }
        public void DisplayTargetHeartRate()
        {
            Console.WriteLine("Target heart rate: {0}", TargetHeartRate());
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            HealthProfile healthProfile = new HealthProfile(null, null, null, null, 0, 0, 0, 0, 0);

            Console.WriteLine("Please Enter First Name:");
            healthProfile.FirstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter Last Name:");
            healthProfile.LastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter Gender:");
            healthProfile.Gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter Month of Birth:");
            healthProfile.MonthOfBirth = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter day of birth:");
            healthProfile.DayOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter year of birth:");
            healthProfile.YearOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Height in inches:");
            healthProfile.HeightInInches = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter weight in pounds:");
            healthProfile.WeightInPounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Current Year:");
            healthProfile.CurrentYear = Convert.ToInt32(Console.ReadLine());


            healthProfile.DisplayFirstName();
            healthProfile.DisplayLastName();
            healthProfile.DisplayGender();
            healthProfile.DisplayMonthOfBirth();
            healthProfile.DisplayDayOfBirth();
            healthProfile.DisplayYearOfBirth();
            healthProfile.DisplayHeightInInches();
            healthProfile.DisplayWeightInPounds();
            healthProfile.DisplayCurrentYear();
            healthProfile.DisplayAge();
            healthProfile.DisplayMaxHeartRate();
            healthProfile.DisplayTargetHeartRate();
            healthProfile.DisplayBodyMassIndex();
            healthProfile.DisplayBMIOutput();
            healthProfile.DisplayBMIChart();

            Console.ReadLine();
            // To delay the program before it terminates

        }
    }
}
