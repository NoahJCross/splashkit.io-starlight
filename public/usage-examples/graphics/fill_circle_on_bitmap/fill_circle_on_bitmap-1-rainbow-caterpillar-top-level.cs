using SplashKitSDK;
using static SplashKitSDK.SplashKit;

// Create a window and bitmap for our caterpillar
Window window = OpenWindow("Window", 400, 200);
Bitmap bitmap = CreateBitmap("caterpillar", 400, 200);

// Fill background with light color
ClearBitmap(bitmap, ColorWhite());

// Create rainbow colors array
Color[] colors = { ColorRed(), ColorOrange(), ColorYellow(),
                          ColorGreen(), ColorBlue(), ColorViolet() };

// Draw circles for caterpillar segments with alternating y positions
double x = 50;
for (int i = 0; i < colors.Length; i++)
{
    double y = 100 + (i % 2 == 0 ? 20 : -20);  // Alternate up and down
    FillCircleOnBitmap(bitmap, colors[i], x, y, 40);
    x += 60;
}

// Draw eyes (adjusted to match first segment position)
FillCircleOnBitmap(bitmap, ColorBlack(), 60, 100, 8);
FillCircleOnBitmap(bitmap, ColorBlack(), 60, 130, 8);

while (!window.CloseRequested)
{
    ProcessEvents();
    // Draw the bitmap to the window
    DrawBitmap(bitmap, 0, 0);
    // Refresh the window
    RefreshScreen();
}
FreeBitmap(bitmap);