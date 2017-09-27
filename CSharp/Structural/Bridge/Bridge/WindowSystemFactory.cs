using System;

namespace Structural.Bridge
{
    public class WindowSystemFactory
    {
        private static WindowSystemFactory _instance;

        private WindowSystemFactory() { }

        public static WindowSystemFactory Instance()
        {
            if (_instance == null)
            {
                _instance = new WindowSystemFactory();
            }

            return _instance;
        }

        public WindowImp MakeWindowImp()
        {
            throw new NotImplementedException();
        }

        internal View MakeView()
        {
            throw new NotImplementedException();
        }
    }
}
