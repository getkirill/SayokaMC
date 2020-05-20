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
        static LauncherFrame mc = new LauncherFrame();
        public static void LaunchMinecraft(string version, bool forge, string username)
        {
            mc.ForgeVersion = "1.12.2";
            mc.Version = version;
            mc.Username = username;
            mc.UserType = "mojang";
            mc.MinRamMb = 1024;
            mc.MaxRamMb = 2048;
            mc.Uuid = "f4eb5883d50c4d49b89ae0458ce76740";
            mc.UseForge = false;
            mc.Height = 480;
            mc.Width = 800;
            mc.MavenPath = "C:/.sayokamc/mvn/bin";

            //mc.DownloadMinecraft("c:/.sayokamc/", "c:/.sayokamc/natives", "c:/.sayokamc/assets", "c:/.sayokamc/libs");
            mc.RunGame("c:/.sayokamc/", "c:/.sayokamc/natives", "c:/.sayokamc/assets", "c:/.sayokamc/libs");
        }
        public static void DownloadMinecraft(string version, bool forge)
        {
            mc.Version = version;
            mc.UseForge = false;
            mc.ForgeVersion = "1.12.2";
            mc.MavenPath = "C:/.sayokamc/mvn/bin";
            mc.DownloadMinecraft("c:/.sayokamc/", "c:/.sayokamc/natives", "c:/.sayokamc/assets", "c:/.sayokamc/libs");
        }
    }
}
