using System;
using System.Collections.Generic;
using System.Text;

namespace VideoEventAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message service: Sending text..." + args.Video.Title);
        }
    }
}
