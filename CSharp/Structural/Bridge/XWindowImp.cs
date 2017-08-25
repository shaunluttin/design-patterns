using System;

namespace Structural.Bridge
{
    /* 
     * "WindowImp, the abstract that declares an interface to the 
     * underlying window system." (Gamma et al)
     */
    public class XWindowImp : WindowImp
    {
        public override void DeviceBitmap(char bitmapName, double v1, double v2)
        { }

        public override void DeviceRect(int x1, int y1, int x2, object y2)
        {
            // TODO Add X window system-specific implementation
        }

        // lots of X Window system-specific state, including
        // Display _dpy;
        // Drawable _windid;
        // GC _gc;
    }
}