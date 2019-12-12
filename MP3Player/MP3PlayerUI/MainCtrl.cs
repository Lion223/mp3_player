using System;
using System.Collections.Generic;
using System.IO;

namespace MP3Player
{
    class MainCtrl
    {
        public static MP3Player.MainForm Link;
        public static string AppPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDi‌​rectory, "..\\..\\"));
        public static List<string> Files = new List<string>();
        public static int CurrTrackNumber;

        public static string GetFile(string file)
        {
            return Path.GetFileNameWithoutExtension(file);
        }

        public static void SetInputFormats()
        {
            Link.ofd.Filter = "All formats|*.mp3; *.alac; *.flac; *.midi; *.opus; *.wma; *.wv"
                + "|MPEG Audio Layer III (*.mp3)|*.mp3"
                + "|Apple Lossless Audio Codec (*.alac)|*.alac"
                + "|Free Lossless Audio Codec (*.flac)|*.flac"
                + "|Musical Instrument Digital Interface (*.midi)|*.midi"
                + "|OPUS Audio (*.opus)|*.opus"
                + "|Windows Media Audio (*.wma)|*.wma"
                + "|WavPack (*.wv)|*.wv";
        }
    }
}
