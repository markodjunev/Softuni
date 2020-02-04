namespace Ferrari
{
    public class Ferrari : IDrivable
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
            this.Name = "488-Spider";
        }

        public string Driver { get; private set; }

        public string Name { get; private set; }

        public string PushTheGas()
        {
            return "Gas!";
        }

        public string UseTheBrakes()
        {
            return "Brakes!";
        }

        public override string ToString()
        {
            return $"{this.Name}/{UseTheBrakes()}/{PushTheGas()}/{this.Driver}";
        }
    }
}