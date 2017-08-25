namespace Structural.Bridge
{
    /*
     * "IconWindow stores the name of a bitmap for the icon it displays...
     * ...and it implements DrawContents to draw the bitmap on the Window."
     */
    public class IconWindow : Window
    {
        private char _bitmapName;

        public override void DrawContents()
        {
            if(WindowImp != null)
            {
                WindowImp.DeviceBitmap(_bitmapName, 0.0, 0.0);
            }
        }
    }
}