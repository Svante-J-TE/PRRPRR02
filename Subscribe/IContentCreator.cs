using System;
using System.Collections.Generic;
using System.Text;

namespace Subscribe
{
    interface IContentCreator
    {
        abstract void Subscribe(PrivateProfile subscriber);
        abstract void Unsubscribe(PrivateProfile subscriber);
    }
}
