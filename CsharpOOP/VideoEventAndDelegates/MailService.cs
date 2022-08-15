using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEventAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail Service: Sending an email..." + e.Video.Title);
        }
    }
}
