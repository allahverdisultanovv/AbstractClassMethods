namespace AbstractClass_Methods
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; }

        public Bicycle(string factoryName, string model, string color, int driveTime, int drivePath, string type)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
            FuelType = "none";
            Type = type;
        }
        public override string DefineNatureHarmness()
        {
            return FuelType;
        }
    }
}
