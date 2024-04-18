using PicSight.View;

namespace PicSight
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("imagedisplaypage", typeof(ImagedisplayPage));
        }
    }
}
