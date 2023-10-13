﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;

public class Engine
{
    public int HorsePower { get; set; }
    public double CubicCapacity { get; set; }

    public Engine(int horsePower, double cubicCapacity)
    {
        this.HorsePower = horsePower;
        this.CubicCapacity = cubicCapacity;
    }
}
public class Tire
{
    public Tire(int year, double pressure)
    {
        this.Year = year;
        this.Pressure = pressure;
    }
    public int Year { get; set; }
    public double Pressure { get; set; }
}
public class Car
{

    private string make;
    private string model;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;
    private Engine engine;
    private Tire[] tire;
    public Car()
    {

    }
    public Car(string make, string model, int year)
      : this()
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
        : this(make, model, year)
    {
        this.FuelConsumption = fuelConsumption;
        this.FuelQuantity = fuelQuantity;
    }
    public Car(string make, string model, int year, double fuelQuantity,
        double fuelConsumption, Engine engine, Tire[] tires)
    {
        this.Engine = engine;
        this.Tires = tires;
    }


    public string Make
    {
        get { return make; }
        set { make = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }
    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }
    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }
    public Tire[] Tires
    {
        get { return tire; }
        set { tire = value; }
    }

    public void Drive(double distance)
    {
        if (distance <= (FuelConsumption * FuelQuantity))
        {
            this.FuelQuantity = (FuelConsumption * FuelQuantity) - distance;
        }
        else
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }
    }
    public string WhoAmI()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Make: {this.Make}");
        sb.AppendLine($"Model: {this.Model}");
        sb.AppendLine($"Year: {this.Year}");
        sb.AppendLine($"Fuel: {this.FuelQuantity:f2}");
        return sb.ToString();
    }

}



