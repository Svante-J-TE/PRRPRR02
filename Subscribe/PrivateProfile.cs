using System;
using System.Collections.Generic;
using System.Text;

namespace Subscribe
{
    class PrivateProfile : IPrivateProfile
    {
        List<ContentCreator> subscribedChannels = new List<ContentCreator>();

        public PrivateProfile(string _name)
        {
            string name = _name;
        }

        public void Notify(ContentCreator channel)
        {
            Console.WriteLine($"{channel.ChannelName} has uploaded a new video");
        }
    }
}
