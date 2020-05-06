using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayokaMC
{
    class MinecraftManager
    {
        PackageManagement packageManagement;
        public MinecraftManager()
        {
            packageManagement = new PackageManagement();
            Console.WriteLine("MinecraftManager initialized");
        }
        class PackageManagement
        {
            ///<summary>
            ///Manage installed packages
            ///</summary>
            public PackageManagement()
            {
                checkInstalledPackages();
            }
            public StatusCode checkInstalledPackages()
            {
                StatusCode code = new StatusCode(0, "Packages successfully checked.");
                return code;
            }
        }
        struct StatusCode
        {
            int statusCode;
            string note;
            public StatusCode(int statusCode) {
                this.statusCode = statusCode;
                this.note = "";
            }
            public StatusCode(int statusCode, string note)
            {
                this.statusCode = statusCode;
                this.note = note;
            }
            public void set(int statusCode)
            {
                this.statusCode = statusCode;
            }
            public void set(int statusCode, string note)
            {
                this.statusCode = statusCode;
                this.note = note;
            }
        }
    }
}
