using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BjxFeedback
{
    public class FeedbackSubmittedEventArgs : System.EventArgs
    {
        public FeedbackSubmittedEventArgs()
        {
            Result = new FeedbackResult();
        }
        public Feedback Feedback { set; get; }
        public FeedbackResult Result { set; get; }
    }
}