namespace Structural.Bridge
{
    /*
     * "ApplicationWindow will implement DrawContents to draw the View
     * instance it stores." (Gamma et al)
     */
    public class ApplicationWindow : Window
    {
        public override void DrawContents()
        {
            View.DrawOn(this);
        }
    }
}
