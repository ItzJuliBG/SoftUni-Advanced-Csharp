﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
                RegistrationNumber = registrationNumber;
        }
        
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }
        public string RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
    }
}
