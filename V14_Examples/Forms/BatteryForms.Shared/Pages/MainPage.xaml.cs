namespace BatteryForms.Shared.Pages
{
    using System;
    using System.ComponentModel;

    using BatteryForms.Shared.Services;
    
    using Xamarin.Forms;

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly BatteryService batteryService;

        public MainPage()
        {
            InitializeComponent();

            this.batteryService = new BatteryService();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.DoOnBatteryServiceCurrentStateChanged(this, null);

            this.batteryService.CurrentStateChanged += this.DoOnBatteryServiceCurrentStateChanged;
        }

        protected override void OnDisappearing()
        {
            this.batteryService.CurrentStateChanged -= this.DoOnBatteryServiceCurrentStateChanged;

            base.OnDisappearing();
        }

        private void DoOnBatteryServiceCurrentStateChanged(object sender, EventArgs eventArgs)
        {
            var currentState = this.batteryService.CurrentState;

            this.ChargeLevelEntry.Text = currentState.ChargeLevel;
            this.StateEntry.Text = currentState.State;
            this.PowerSourceEntry.Text = currentState.PowerSource;
        }
    }
}
