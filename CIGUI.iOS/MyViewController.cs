namespace CIGUI.iOS
{
    using System;
    using System.Drawing;

    using CIBackend;

    using MonoTouch.UIKit;

    public class MyViewController : UIViewController
    {
        private readonly float buttonHeight = 50;
        private readonly float buttonWidth = 200;
        private readonly CounterLogic _counter;
        private UIButton button;

        public MyViewController()
        {
            _counter = new CounterLogic();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.Frame = UIScreen.MainScreen.Bounds;
            View.BackgroundColor = UIColor.White;
            View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            button = UIButton.FromType(UIButtonType.RoundedRect);

            button.Frame = new RectangleF(
                View.Frame.Width / 2 - buttonWidth / 2,
                View.Frame.Height / 2 - buttonHeight / 2,
                buttonWidth,
                buttonHeight);

            button.SetTitle("Click me", UIControlState.Normal);

            button.TouchUpInside += (object sender, EventArgs e) =>{
                _counter.Increment();
                button.SetTitle(String.Format("clicked {0} times", _counter.Counter), UIControlState.Normal);
            };

            button.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleTopMargin |
                                      UIViewAutoresizing.FlexibleBottomMargin;

            View.AddSubview(button);

			// Jenkins Test
			// Jenkins will automatically build after you commit & push your code on git.
        }
    }
}
