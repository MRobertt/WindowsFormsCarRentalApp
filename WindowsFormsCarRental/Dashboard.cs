using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CarRentClassLibrary;

namespace WindowsFormsCarRental
{
    public partial class Dashboard : Form
    {
        //store the available cars
        BindingList<string> availableCars = new BindingList<string>() { "Mazda", "Ford", "Dacia"};

        //store data about customer info
        BindingList<string> rentCarData = new BindingList<string>();
        BindingList<string> returnCarData = new BindingList<string>();

        //message rent and return validation / errors
        BindingList<string> rentCarMessage = new BindingList<string>();
        BindingList<string> returnCarMessage = new BindingList<string>();

        //could use CSV helper for csv files
        public string rentalPath = @"C:\Users\eXpert\Desktop\rentData.csv";
        public string returnedPath = @"C:\Users\eXpert\Desktop\returnData.csv";

        public Dashboard()
        {
            InitializeComponent();
            availableCarsWindow.DataSource = availableCars;
            rentCarMessageWindow.DataSource = rentCarMessage;
            returnMessageWindow.DataSource = returnCarMessage;
        }

        private void rentFinishBtn_Click(object sender, EventArgs e)
        {
            string rentPeriod;
            bool oneDayValidation = radioOneDay.Checked;
            bool oneWeekValidation = radioOneWeek.Checked;
            bool oneMonthValidation = radioOneMonth.Checked;      
            string currentDate = DateTime.Now.ToString();

            RentModel rentedCar = new RentModel()
            {
                FirstName = rentFirstNameInput.Text,
                LastName = rentLastNameInput.Text,
                PhoneNumber = rentPhoneNumberInput.Text,
                CarMake = rentCarMakeInput.Text
            };


            if (oneDayValidation)
            {
                rentPeriod = radioOneDay.Text;
            }
            else if (oneWeekValidation)
            {
                rentPeriod = radioOneWeek.Text;
            }
            else if (oneMonthValidation)
            {
                rentPeriod = radioOneMonth.Text;
            }
            else
            {
                rentPeriod = exactRentPeriod.Text;
            }

            //this works do the same on return

            if (!availableCars.Contains(rentedCar.CarMake) || availableCars.Count == 0)
            {
                    rentCarMessage.Add($"The car {rentedCar.CarMake} is not available, please verify the available car list.");
            }
            else
            {

                string message = $"{rentedCar.CarMake} was succesfully rented for {rentPeriod} by {rentedCar.FirstName} {rentedCar.LastName} at {currentDate}.";

                rentCarData.Add(rentedCar.FirstName);
                rentCarData.Add(rentedCar.LastName);
                rentCarData.Add(rentedCar.PhoneNumber);
                rentCarData.Add(rentedCar.CarMake);
                rentCarData.Add(message);
                rentCarMessage.Add(message);
                availableCars.Remove(rentedCar.CarMake);

                rentFirstNameInput.Text = "";
                rentLastNameInput.Text = "";
                rentPhoneNumberInput.Text = "";
                rentCarMakeInput.Text = "";
                exactRentPeriod.Text = "";
               
            }
            
            using var writer = new StreamWriter(rentalPath, true);
            foreach (string rental in rentCarData)
            {
                string lastElement = rentCarData.Last();
                if (lastElement == rental)
                {
                    writer.Write(rental);
                }
                else
                {
                    writer.Write(rental + ",");
                }
            }
            writer.WriteLine();

            writer.Close();

        }

        private void returnFinishBtn_Click(object sender, EventArgs e)
        {
            ReturnedModel returnedCar = new ReturnedModel() {
                FirstName = returnFirstName.Text,
                LastName = returnLastName.Text,
                PhoneNumber = returnPhoneNumber.Text,
                CarMake = returnCarMake.Text
            };
            
            string currentDate = DateTime.Now.ToString();
            

            using (var writer = new StreamWriter(returnedPath, true))
            {
                foreach (string returnedRental in returnCarData)
                {
                    string lastElement = returnCarData.Last();
                    if (lastElement == returnedRental)
                    {
                        writer.Write(returnedRental);
                    }
                    else
                    {
                        writer.Write(returnedRental + ",");
                    }         
                }
                writer.WriteLine();

                writer.Close();
            }

            if (!rentCarData.Contains(returnedCar.CarMake))
            {
                returnCarMessage.Add($"The car {returnedCar.CarMake} is already returned or not found.");
            }
            else
            {
                string message = $"{returnedCar.CarMake} was succesfully returned by {returnedCar.FirstName} {returnedCar.LastName} at {currentDate}.";

                returnCarData.Add(returnedCar.FirstName);
                returnCarData.Add(returnedCar.LastName);
                returnCarData.Add(returnedCar.PhoneNumber);
                returnCarData.Add(returnedCar.CarMake);
                returnCarData.Add(message);
                returnCarMessage.Add(message);
                rentCarData.Remove(returnedCar.CarMake);
                availableCars.Add(returnedCar.CarMake);

                returnFirstName.Text = "";
                returnLastName.Text = "";
                returnPhoneNumber.Text = "";
                returnCarMake.Text = "";

            }
        }

        //this button doesnt do anything right now
        private void showCarsBtn_Click(object sender, EventArgs e)
        {
            foreach(string car in availableCars)
            {
                Console.WriteLine(car);
            }
                
        }

        //on text change of rental period, the radio buttons uncheck
        private void exactRentPeriod_TextChanged(object sender, EventArgs e)
        {
            radioOneDay.Checked = false;
            radioOneWeek.Checked = false;
            radioOneMonth.Checked = false;
        }
    }
}
