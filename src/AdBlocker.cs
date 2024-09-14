namespace NitroType3 
{
    //better ad blocker
    class AdBlocker
    {
        private static string[] BlockedDomains = {
            "btloader.com",
            "bugsnag.com",
            "cloudfront.net",
            "cloudflareinsights.com",
            "doubleclick.net",
            "facebook.net",
            "facebook.com",
            "googletagmanager.com",
            "intergient.com",
            "proper.io",
            "pub.network",
            "qualaroo.com",
            "vuukle.com",
            "googlevideo.com",
            "youtube.com",
            "ytimg.com",
            "googleadservices.com",
            "gstatic.com",
            "doubleclick.net"
        };

        private static string[] BlockedUrls = {
            "https://marketingmecca.net",
            "https://cdn.fluidplayer.com",
            "https://www.googleadservices.com/",
            "https://www.youtube.com/get_video_info",
            "https://www.youtube.com/api/stats/ads",
            "https://www.youtube.com/pagead"
        };

        public static bool IsBlocked(string Uri)
        {
            for (int i = 0; i < BlockedDomains.Length; i++)
            {
                if (Uri.Contains(BlockedDomains[i]))
                {
                    return true;
                }
            }

            for (int i = 0; i < BlockedUrls.Length; i++)
            {
                if (Uri.Equals(BlockedUrls[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
