using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WindowsFormsApplication1
{
    public class music
    {
        private static readonly SoundPlayer simpleSound = new SoundPlayer(@"../../sound/music.wav");

        //making instance accessible from other classes
        public static SoundPlayer SoundPlayerInstance
        {
            get { return simpleSound; }
        }

        public static bool medplay = true;

    }
}
