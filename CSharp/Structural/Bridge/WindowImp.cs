using System;

namespace Structural.Bridge
{
    /* 
     * "WindowImp, the abstract that declares an interface to the 
     * underlying window system." (Gamma et al)
     */
    public abstract class WindowImp
    {
        public abstract void DeviceBitmap(char bitmapName, double v1, double v2);

        public abstract void DeviceRect(int x1, int y1, int x2, object y2);
    }
}