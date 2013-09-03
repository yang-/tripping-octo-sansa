namespace CIGUI.Android
{
    using CIBackend;

    using global::Android.App;
    using global::Android.OS;
    using global::Android.Widget;

    [Activity(Label = "CIGUI.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        /// <summary>
        ///   Gets the backend Business Logic Module that will provide access to all common shared functions and
        ///   properties for this mobile enterprise application
        /// </summary>
        public CounterLogic Counter { get; private set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Counter = new CounterLogic(100);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            // Use the Business Logic Module to decrement the counter and display
            button.Click += delegate { button.Text = string.Format("{0} clicks!", Counter.Decrement()); };
        }
    }
}
