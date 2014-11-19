using Xamarin.Media;
// ...

protected override void OnCreate (Bundle bundle)
{
    var picker = new MediaPicker (this);
    if (!picker.IsCameraAvailable)
        Console.WriteLine ("No camera!");
    else {
        var intent = picker.GetTakePhotoUI (
            new StoreCameraMediaOptions {
            Name = "test.jpg",
            Directory = "MediaPickerSample"
        });
        StartActivityForResult (intent, 1);
    }
}

protected override async void OnActivityResult (
    int requestCode, Result resultCode, Intent data)
{
    // User canceled
    if (resultCode == Result.Canceled)
        return;

    MediaFile file = await data.GetMediaFileExtraAsync (this);
    Console.WriteLine (file.Path);
}