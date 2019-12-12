using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Un4seen.Bass;

namespace MP3Player
{
    public static class BassCtrl
    {
        public static int hz = 44100;
        public static bool init;
        public static int Stream;
        public static int volume = 50;
        private static bool manuallyStoped = true;
        public static bool EndPlaylist;
        private static readonly List<int> BassPluginsHandlers = new List<int>();

        public static bool InitBass(int hz)
        {
            if (!init)
            {
                init = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if (init)
                {
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(MainCtrl.AppPath + @"plugins\bassalac.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(MainCtrl.AppPath + @"plugins\bassflac.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(MainCtrl.AppPath + @"plugins\bassmidi.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(MainCtrl.AppPath + @"plugins\bassopus.dll"));
                    BassPluginsHandlers.Add(Bass.BASS_PluginLoad(MainCtrl.AppPath + @"plugins\basswv.dll"));

                    int errCount = 0;
                    for (int i = 0; i < BassPluginsHandlers.Count; i++)
                        if (BassPluginsHandlers[i] == 0)
                            errCount++;
                    if (errCount != 0)
                        MessageBox.Show(errCount + " plugins couldn't load in.");
                    errCount = 0;
                }
            }

            return init;
        }

        public static void SetPosBar(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }

        public static int GetTimeStream(int stream)
        {
            long timebytes = Bass.BASS_ChannelGetLength(stream);
            int timestream = (int)Bass.BASS_ChannelBytes2Seconds(stream, timebytes);
            return timestream;
        }

        public static int GetPosStream(int stream)
        {
            long posbytes = Bass.BASS_ChannelGetPosition(stream);
            int posstream = (int)Bass.BASS_ChannelBytes2Seconds(stream, posbytes);
            return posstream;
        }

        public static void Play(string filename, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(hz))
                {
                    Stream = Bass.BASS_StreamCreateFile(filename, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100F);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else
                Bass.BASS_ChannelPlay(Stream, false);
            manuallyStoped = false;
        }

        public static void Pause()
        {
            if (Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING)
                Bass.BASS_ChannelPause(Stream);
        }
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            manuallyStoped = true;
        }

        public static void SetVolume(int stream, int vol)
        {
            volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, volume / 100F);
        }

        public static bool ToNext()
        {
            if ((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!manuallyStoped))
            {
                if (MainCtrl.Files.Count > MainCtrl.CurrTrackNumber + 1)
                {
                    Play(MainCtrl.Files[++MainCtrl.CurrTrackNumber], volume);
                    EndPlaylist = false;
                    return true;
                }
                else
                    EndPlaylist = true;
            }
            return false;
        }
    }
}
