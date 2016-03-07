# Requirements

In order to use the Pinterest SDK, the Pinterest mobile application must be installed 
on the device, both for iOS and Android. The Pinterest application is a free application.

## Usage

### iOS

In order to use "PinItButton" in your iOS application the developer needs to initialize 
the Pinterest SDK with a Client ID that can be obtained on the Pinterest developer site. 
After SDK initialization is complete, setup a UIButton in UIViewController's ViewDidLoad 
method by obtaining an instance of it from SDK, using "GetPinItButton". Place the button 
within the view by setting its Frame and adding it as a subview.  Add a handler for the 
"TouchUpInside" event on the button, and call "CreatePin" if all requirements are met 
add your content, within it.


PinterestViewController.cs

```csharp
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			View.BackgroundColor = UIColor.White;
			Title = "Pmterest Pint It Demo";

			// Initialize a Pinterest instance with client_id
			pinterest = new Pinterest ("1234", "prod");

			// Setup a sample imageview for the image we want to pin
			var sampleImage = UIImage.LoadFromData (
				NSData.FromUrl (
					NSUrl.FromString ("http://placekitten.com/500/400")
				)
			);
			sampleImageView = new UIImageView (sampleImage) {
				Frame = new RectangleF (0, 61, 320, 200)
			};

			View.AddSubview (sampleImageView);

			// Setup PinIt Button
			pinItButton = Pinterest.GetPinItButton ();
			pinItButton.Frame = new RectangleF (124, 281, 72, 32);

			// Add button handler
			pinItButton.TouchUpInside += (sender, e) => {
				// Check if we can pin or if we are using simulator
				if (!pinterest.CanPin)
					new UIAlertView 
							(
							  "Error:"
							, "Pinterest SDK can't pin if you are using simulator or "
							  + "you don't have Pinterest app :'("
							, null
							, "Ok"
							, null
							).Show ();
				else 
				pinterest.CreatePin (NSUrl.FromString ("http://placekitten.com/500/400"),
					NSUrl.FromString ("http://placekitten.com"),
						"Pinning from Pin It Demo"
				);
			};

			View.AddSubview (pinItButton);
		}
```

### Android

Generally PinIt button is defined in layout markup in Android xml (axml) file

```xml
    <com.pinterest.pinit.PinItButton
        android:id="@+id/pin_bt"
        android:layout_width="wrap_content"
        android:layout_height="wrap_content"
        android:layout_margin="@dimen/global_padding" 
		/>
```

NOTE: There is namespace error in Pinterest original demo.

Initialization of the Pinterest SDK occurs in OnCreate method of the Activity:

```csharp
			// SDK initialization
			PinterestSDK.PinIt.PinItButton.DebugMode = true;
			PinterestSDK.PinIt.PinItButton.PartnerId = "1234";

			PinItButton pinIt = FindViewById<PinItButton> (Resource.Id.pin_bt);
			pinIt.ImageUrl = IMAGE_SOURCE;
			pinIt.Url  = WEB_URL;
			pinIt.Description  = description;
			pinIt.Listener = _listener;
```

There are 3 samples for Android platform and for more insights and details check
accompanying component samples.


NOTE: Do not forget change client_id (partner id) to your client_id which can be
obtained on Pinterest site.

Client ID in samples is string "1234" and in iOS sample is passed as constructor argument,
while in Android it is static property of the PinItButton class.
