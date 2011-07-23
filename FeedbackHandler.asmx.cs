using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

namespace BjxFeedback
{
    /// <summary>
    /// Summary description for SubmitFeedback1
    /// </summary>
    [WebService(Namespace = "http://designbyssi.com/BjxFeedback")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)] 
    [System.Web.Script.Services.ScriptService]
    public class FeedbackHandler : System.Web.Services.WebService
    {
        private static event EventHandler<FeedbackSubmittedEventArgs> _onFeedbackSubmitted;
        public static EventHandler<FeedbackSubmittedEventArgs> OnFeedbackSubmitted
        {
            set
            {
                if (_onFeedbackSubmitted == null)
                    _onFeedbackSubmitted = value;
            }
            get
            {
                return _onFeedbackSubmitted;
            }
        }
        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public FeedbackResult SubmitFeedback(Feedback data)
        {
            if (OnFeedbackSubmitted == null)
                throw new NullReferenceException("OnFeedbackSubmitted event must be configured in Global.asax");
            FeedbackSubmittedEventArgs args = new FeedbackSubmittedEventArgs();
            OnFeedbackSubmitted(this, args);         
            return args.Result;
        }
    }
}
