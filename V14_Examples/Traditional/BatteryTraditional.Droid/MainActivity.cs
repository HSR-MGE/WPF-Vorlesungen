namespace BatteryTraditional.Droid
{
    using System;

    using Android.App;
    using Android.OS;
    using Android.Runtime;
    using Android.Widget;
    using AndroidX.AppCompat.App;

    using BatteryTraditional.Shared.Services;

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private BatteryService batteryService;
        private EditText edtChargeLevel;
        private EditText edtState;
        private EditText edtPowerSource;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            this.SetContentView(Resource.Layout.activity_main);

            var toolbar = this.FindViewById<AndroidX.AppCompat.Widget.Toolbar>(Resource.Id.toolbar);
            this.SetSupportActionBar(toolbar);

            this.batteryService = new BatteryService();
            this.edtChargeLevel = this.FindViewById<EditText>(Resource.Id.edt_charge_level);
            this.edtState = this.FindViewById<EditText>(Resource.Id.edt_state);
            this.edtPowerSource = this.FindViewById<EditText>(Resource.Id.edt_power_source);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnResume()
        {
            base.OnResume();

            this.DoOnBatteryServiceCurrentStateChanged(this, null);

            this.batteryService.CurrentStateChanged += this.DoOnBatteryServiceCurrentStateChanged;
        }

        protected override void OnPause()
        {
            this.batteryService.CurrentStateChanged -= this.DoOnBatteryServiceCurrentStateChanged;

            base.OnPause();
        }

        private void DoOnBatteryServiceCurrentStateChanged(object sender, EventArgs eventArgs)
        {
            var currentState = this.batteryService.CurrentState;

            this.edtChargeLevel.Text = currentState.ChargeLevel;
            this.edtState.Text = currentState.State;
            this.edtPowerSource.Text = currentState.PowerSource;
        }
    }
}

