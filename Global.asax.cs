using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BjxFeedback
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (HttpContext.Current.Request.Url.ToString().EndsWith("/FeedbackHandler.asmx/SubmitFeedback"))
            {
                FeedbackHandler.OnFeedbackSubmitted += new EventHandler<FeedbackSubmittedEventArgs>(FeedbackHandler_OnFeedbackSubmitted);
            }
        }

        void FeedbackHandler_OnFeedbackSubmitted(object sender, FeedbackSubmittedEventArgs e)
        {
            e.Result.response = "Thank you for your submission";
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}