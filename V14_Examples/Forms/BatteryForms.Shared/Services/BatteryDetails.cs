namespace BatteryForms.Shared.Services
{
    public sealed class BatteryDetails
    {
        public BatteryDetails()
            : this("Unknown", "Unknown", "Unknown")
        {
        }

        public BatteryDetails(string chargeLevel, string state, string powerSource)
        {
            this.ChargeLevel = chargeLevel;
            this.State = state;
            this.PowerSource = powerSource;
        }

        public string ChargeLevel { get; }

        public string State { get; }

        public string PowerSource { get; }
    }
}
