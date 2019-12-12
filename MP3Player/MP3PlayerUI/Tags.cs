using System.Collections.Generic;
using Un4seen.Bass.AddOn.Tags;

namespace MP3Player
{
    public class Tags
    {
        public int Bitrate;
        public int Freq;
        public string Channel;
        public string Artist;
        public string Title;
        public string Album;
        public string Year;

        Dictionary<int, string> ChannelDict = new Dictionary<int, string>()
        {
            {0, "Null" },
            {1, "Mono" },
            {2, "Stereo" }
        };

        public Tags(string file)
        {
            TAG_INFO tagInfo = new TAG_INFO();
            tagInfo = BassTags.BASS_TAG_GetFromFile(file);
            if (tagInfo != null)
            {
                Bitrate = tagInfo.bitrate;
                Freq = tagInfo.channelinfo.freq;
                Channel = ChannelDict[tagInfo.channelinfo.chans];
                Artist = tagInfo.artist;
                Album = tagInfo.album;
                Year = tagInfo.year;
                if (tagInfo.title == "")
                    Title = MainCtrl.GetFile(file);
                else
                    Title = tagInfo.title;
            }
        }
    }
}
