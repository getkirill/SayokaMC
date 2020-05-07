using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MineSharp.Common.Game;

namespace SayokaMC
{
    class MinecraftManager
    {
        public static void LaunchMinecraft(string version, string username)
        {
            var mc = new LauncherFrame();
            mc.Version = version;
            mc.Username = username;
            mc.UserType = "mojang";
            mc.MinRamMb = 1024;
            mc.MaxRamMb = 2048;
            mc.Uuid = "f4eb5883d50c4d49b89ae0458ce76740";
            mc.UseForge = false;
            mc.Height = 480;
            mc.Width = 800;
            mc.MavenPath = "%appdata%/.sayokamc/mvn/bin";

            //mc.DownloadMinecraft("c:/.sayokamc/", "c:/.sayokamc/natives", "c:/.sayokamc/assets", "c:/.sayokamc/libs");
            mc.RunGame("c:/.sayokamc/", "c:/.sayokamc/natives", "c:/.sayokamc/assets", "c:/.sayokamc/libs");
        }
        public static void DownloadMinecraft()
        {
            var mc = new LauncherFrame();
            mc.DownloadMinecraft("c:/.sayokamc/", "c:/.sayokamc/natives", "c:/.sayokamc/assets", "c:/.sayokamc/libs");
        }
    }
}
