using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlay
{
    

    public static class PauseClass
    {
        public delegate void Pause();
        public static Pause EventHandler;
    }

    public static class VperedClass
    {
        public delegate void Vpered();
        public static Vpered EventHandler;
    }

    public static class NazadClass
    {
        public delegate void Nazad();
        public static Nazad EventHandler;
    }


    public static class LoopClass
    {
        public delegate void Loop();
        public static Loop EventHandler;
    }

    public static class SmeshClass
    {
        public delegate void Smesh();
        public static Smesh EventHandler;
    }

    public static class NewSong
    {
        public delegate void Song(string song);
        public static Song EventHandler;
    }

    public static class PlaylistClass
    {
        public delegate void Playlist(string playlistName);
        public static Playlist EventHandler;
    }

    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
