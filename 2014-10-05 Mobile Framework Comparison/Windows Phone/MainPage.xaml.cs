PhotoCamera cam;

//Set the VideoBrush source to the camera.
viewfinderBrush.SetSource(cam);

private void ShutterButton_Click(
	object sender, RoutedEventArgs e)
{ 
    cam.CaptureImage();
}

void cam_CaptureCompleted(
	object sender, 
	CameraOperationCompletedEventArgs e
	)
    {
        // Capture is completed 
        // at this point
        savedCounter++;
    }
void cam_CaptureImageAvailable(
	object sender, 
	Microsoft.Devices.ContentReadyEventArgs e)
    {
    	//full resolution photo is available
    	// save it, send it... Do whatever 
    }