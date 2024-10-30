namespace AbstractClass_Methods
{
    internal abstract class Vehicle
    {
        private string _factoryName;
        private string _model;
        private string _color;
        private int _driveTime;
        private int _drivePath;
        public string FuelType { get; set; }

        public string FactoryName
        {

            get { return _factoryName; }
            set
            {
                _factoryName = value;
            }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }

        public decimal AvarageSpeed()
        {
            return DrivePath / DriveTime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"{FactoryName}");
        }

        public override string ToString()
        {
            return $"{FactoryName}  , {Model} ,{Color}";
        }
        public abstract string DefineNatureHarmness();
    }
}
