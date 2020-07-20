using UIKit;
using CometChatPro;

namespace SampleApp.Native.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");

            var appSettings = (new AppSettingsBuilder()).GetSubscribePresenceForAllUsers().SetRegionWithRegion("us").Build();

            new CometChat("211751a156c3006", appSettings, (bool success) =>
            {
            }, (CometChatException error) =>
            {

            });

        }
    }
}