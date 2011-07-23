using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BjxFeedback
{
    public class Feedback
    {
        public string browser { set; get; }
        public string version { set; get; }
        public string platform { set; get; }
        public string userAgent { set; get; }
        public bool cookiesEnabled { set; get; }
        public string message { set; get; }
        public string screenShot { set; get; }
    }
}