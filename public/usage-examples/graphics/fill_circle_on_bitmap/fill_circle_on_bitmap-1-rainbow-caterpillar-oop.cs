using SplashKitSDK;

namespace FillCircleOnBitmap
{
    public class Program
    {
        public static void Main()
        {
            // Create a window and bitmap for our caterpillar
            Window window = new Window("Window", 400, 200);
            Bitmap bitmap = new Bitmap("caterpillar", 400, 200);

            // Fill background with light color
            bitmap.Clear(Color.White);

            // Create rainbow colors array
            Color[] colors = { Color.Red, Color.Orange, Color.Yellow,
                             Color.Green, Color.Blue, Color.Violet };

            // Draw circles for caterpillar segments with alternating y positions
            double x = 50;
            for (int i = 0; i < colors.Length; i++)
            {
                double y = 100 + (i % 2 == 0 ? 20 : -20);  // Alternate up and down
                bitmap.FillCircle(colors[i], x, y, 40);
                x += 60;
            }

            // Draw eyes (adjusted to match first segment position)
            bitmap.FillCircle(Color.Black, 60, 100, 8);
            bitmap.FillCircle(Color.Black, 60, 130, 8);

            while (!window.CloseRequested)
            {
                SplashKit.ProcessEvents();
                // Draw the bitmap to the window
                window.DrawBitmap(bitmap, 0, 0);
                // Refresh the window
                SplashKit.RefreshScreen();
            }

            bitmap.Free();
        }
    }
}