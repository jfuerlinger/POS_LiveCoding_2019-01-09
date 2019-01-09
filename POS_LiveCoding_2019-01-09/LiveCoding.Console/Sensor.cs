namespace LiveCoding.Console
{
    public class Sensor
    {
        private string _unit;

        public string Name { get; set; }
        public double Value { get; set; }

        public Sensor()
        {
            _unit = "xxx";
        }
    }
}
