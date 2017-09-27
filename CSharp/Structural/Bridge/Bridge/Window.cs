using Structural.Shared;

namespace Structural.Bridge
{
    /*
     * "The Window class defined the window abstraction
     * for client applications." (Gamma et al)
     */
    public abstract class Window
    {
        // requests handled by window
        public abstract void DrawContents();

        // requests forwarded to implementation
        public void DrawRect(Point bottomLeft, Point topRight)
        {
            WindowImp.DeviceRect(bottomLeft.X, bottomLeft.Y, topRight.X, topRight.Y);
        }

        private WindowImp _imp;
        private View _view;

        protected WindowImp WindowImp
        {
            get
            {
                if (_imp == null)
                {
                    _imp = WindowSystemFactory.Instance().MakeWindowImp();
                }

                return _imp;
            }
        }

        protected View View
        {
            get
            {
                if (_view == null)
                {
                    _view = WindowSystemFactory.Instance().MakeView();
                }

                return _view;
            }
        }
    }
}
