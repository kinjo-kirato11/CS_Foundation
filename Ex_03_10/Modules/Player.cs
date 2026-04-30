using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03_10.Modules
{
    public abstract class Player
    {
        public String Media { get; set; }
        public Player(string Media)
        {
            this.Media = Media;
        }
        public abstract void Play();
        public abstract void Stop();
    }

}
