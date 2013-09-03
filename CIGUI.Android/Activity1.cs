using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using CIBackend;

namespace CIGUI.Android
{
    [Activity(Label = "CIGUI.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        #region Private Variables
        // Create a new Business Logic Module and set the initial counter value to 100 
        MyCounter myCounter = new MyCounter(100);
        #endregion

        #region Computed Properties
        /// <summary>
        /// Gets the backend Business Logic Module that will provide access to all common shared functions and
        /// properties for this mobile enterprise application
        /// </summary>
        public MyCounter MyCounter{
            get { return myCounter; }
        }
        #endregion

        #region Override Methods
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            // Use the Business Logic Module to decrement the counter and display
            button.Click += delegate { button.Text = string.Format("{0} clicks!", MyCounter.Decrement()); };
        }
        #endregion
    }
}

