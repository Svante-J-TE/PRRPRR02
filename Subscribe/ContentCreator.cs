using System;
using System.Collections.Generic;
using System.Text;

namespace Subscribe
{
    class ContentCreator : IContentCreator
    {
        List<PrivateProfile> subscribersList = new List<PrivateProfile>();

        private string channelName;

        public string ChannelName
        {
            get { return channelName; }
            set { channelName = value; }
        }


        public ContentCreator(string _name) {
            channelName = _name;
        }

        public void Subscribe(PrivateProfile subscriber)
        {
            subscribersList.Add(subscriber);
        }

        public void Unsubscribe(PrivateProfile subscriber)
        {
            subscribersList.Remove(subscriber);
        }
    }
}
