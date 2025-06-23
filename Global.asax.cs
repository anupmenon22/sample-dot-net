using System;
using System.Web;

namespace SampleDotNetApp
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
        }

        protected void Application_End(object sender, EventArgs e)
        {
            // Code that runs on application shutdown
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
        }

        protected void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends
        }
    }
}
