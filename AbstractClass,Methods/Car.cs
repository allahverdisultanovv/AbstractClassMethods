namespace AbstractClass_Methods
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }

        public Car(string factoryName, string model, string color, int driveTime, int drivePath, string fuelType, int doorcount, bool isElectricCar)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
            FuelType = fuelType;
            DoorCount = doorcount;
            IsElectricCar = isElectricCar;
        }
        public override string DefineNatureHarmness()
        {
            return FuelType;
        }
    }
}
