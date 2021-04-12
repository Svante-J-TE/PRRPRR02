using System;
using System.Collections.Generic;
using System.Text;

namespace Subscribe
{
    interface IPrivateProfile
    {
        abstract void Notify(ContentCreator upload);
    }
}
