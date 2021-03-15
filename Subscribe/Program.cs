using System;

namespace Subscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Content creators are created
            ContentCreator dualDGaming = new ContentCreator("DualDGaming");
            ContentCreator callMeKevin = new ContentCreator("CallMeKevin");
            ContentCreator dudePerfect = new ContentCreator("DudePerfect");
            ContentCreator donutMedia = new ContentCreator("DonutMedia");
            ContentCreator carwow = new ContentCreator("CarWow");

            //Prifiles used to watch the creators are created
            PrivateProfile svante = new PrivateProfile("svante");

            //user subsribes to a channel
            donutMedia.Subscribe(svante);

            //user is notified channel uploaded a video
            svante.Notify(donutMedia);
        }
    }
}
