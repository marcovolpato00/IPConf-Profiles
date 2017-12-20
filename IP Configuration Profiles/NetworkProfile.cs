using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Configuration_Profiles
{
    [Serializable]
    class NetworkProfile
    {
        #region Campi pubblici

        public string Name { get; set; }
        public string Interface { get; set; }
        public string IPAddress { get; set; }
        public string Netmask { get; set; }
        public string Gateway { get; set; }
        public string DNS1 { get; set; }
        public string DNS2 { get; set; }

        #endregion

        #region Campi privati

        private bool DHCP;

        #endregion

        #region Costruttori

        public NetworkProfile(string name, string nic, string ip, string netmask, string gateway, string dns1, string dns2)
        {
            Name = name;
            Interface = nic;
            IPAddress = ip;
            Netmask = netmask;
            Gateway = gateway;
            DNS1 = dns1;
            DNS2 = dns2;
        }

        public NetworkProfile(string name, string nic)
        {
            Name = name;
            Interface = nic;
            DHCP = true;
        }

        #endregion

        #region Metodi pubblici

        public void Apply()
        {
            if (!DHCP)
            {
                ApplyStatic();
            }
            else
            {
                ApplyDHCP();
            }
        }

        public void ApplyToAnotherInterface(string nic)
        {
            if (!DHCP)
            {
                ApplyStatic(nic);
            }
            else
            {
                ApplyDHCP(nic);
            }
        }

        #endregion

        #region Metodi privati

        private void ApplyStatic([Optional]string nic)
        {
            if (nic == null)
            {
                nic = Interface;
            }

            string command = "interface ip set address name=\"" + nic + "\" source=static addr=" + IPAddress + " mask=" + Netmask + " gateway=" + Gateway;
            RunCommand("netsh", command);     

            command = "interface ip set dns \"" + nic + "\" static " + DNS1 + " primary";
            RunCommand("netsh", command);     

            command = "interface ip set dns \"" + nic + "\" static " + DNS2 + " index=2";
            RunCommand("netsh", command);     
        }

        private void ApplyDHCP([Optional]string nic)
        {
            if (nic == null)
            {
                nic = Interface;
            }

            string command = "interface ip set address name=\"" + nic + "\" source=dhcp";
            RunCommand("netsh", command);

            command = "interface ip set dns \"" + nic + "\" dhcp";
            RunCommand("netsh", command);
        }

        private void RunCommand(string exec, string command)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = exec;
            startInfo.Arguments = command;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        #endregion
    }
}
