namespace BatteryForms.Shared.Services
{
    using System;
    
    using Xamarin.Essentials;

    public sealed class BatteryService
    {
        public BatteryService()
        {
            this.UpdateCurrentState(
                Battery.ChargeLevel,
                Battery.State,
                Battery.PowerSource);

            Battery.BatteryInfoChanged += this.DoOnBatterInfoChanged;
        }

        public BatteryDetails CurrentState { get; private set; }

        public event EventHandler CurrentStateChanged;

        #region Private Methods

        private void DoOnBatterInfoChanged(object sender, BatteryInfoChangedEventArgs eventArgs)
        {
            this.UpdateCurrentState(
                eventArgs.ChargeLevel,
                eventArgs.State,
                eventArgs.PowerSource);

            this.CurrentStateChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateCurrentState(
            double chargeLevel,
            BatteryState state,
            BatteryPowerSource powerSource)
        {
            this.CurrentState = new BatteryDetails(
                $"{chargeLevel * 100}%",
                state.ToString(),
                powerSource.ToString());
        }

        #endregion
    }
}
