using System;

    public class Battery
    {
        public string batt;
        private double batteryDuration;

        public Battery(string batt = null, double batteryDuration = 0)
        {
            this.Batt = batt;
            this.BatteryDuration = batteryDuration;
        }

        public string Batt
        {
            get { return this.batt; }
            set 
            { 
                if(String.IsNullOrEmpty(value))
                    this.batt = null;
                    this.batt = value;
            }
        }

        public double BatteryDuration
        {
            get { return this.batteryDuration; }
            set { this.batteryDuration = value; }
        }

        public override string ToString()
        {
            return "Battery: " + this.Batt + "  Battery duration: " + this.BatteryDuration ;
        }
    }