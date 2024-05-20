using System;


namespace ClassLibrary1
{
    public class Car
    {
        private string make;
        private string model;
        private decimal rentalprice;
        private bool rented;

        public string Make { set { make = value; } get { return make; } }
        public string Model { set { model = value; } get { return model; } }
        public decimal RentalPrice { set { rentalprice = value; } get { return rentalprice; } }
        public bool Rentted { set { rented = value; } get { return rented; } }

        public void Rent()
        {

            if (Rentted == true)
            {
                Console.WriteLine("selected car is available for rent");
                this.Rentted = false;
            }
            else
            {
                Console.WriteLine("sorry, selected car is not available for rent");
            }
        }
        public void Return()
        {
            if(Rentted == false)
            {
                Console.WriteLine("Thanks for returning the car");
                this.Rentted = true;
            }
            else
            {
                Console.WriteLine("Car is available");
            }
        }
       
    }
}
