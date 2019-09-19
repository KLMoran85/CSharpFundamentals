using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieClassInstantiation()
        {
            Cookie cookie = new Cookie();
           
            cookie.Name = "SnickerDoodle";
            cookie.BatchSize = 122;
            cookie.Direction = "Put together and throw in over";
            cookie.Ingredient = "Secret: Sour Cream";
            cookie.Shape = "Eiffel Tower";
            cookie.Size = "1365 feet";

            Cookie cookieTwo = new Cookie("Chocolate chip", "chocolate chips", "125", "Mix up and place in oven", "Round", 6);

        }

        [TestMethod]
        public void VehicleClassInstantiation()
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Make = "Ford";

            Vehicle vehicleTwo = new Vehicle("Ford", "something", "something", "alid", 84611644, 2654846, true);
        }
    }
}
