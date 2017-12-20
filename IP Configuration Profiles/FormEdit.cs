using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPAddressControlLib;

namespace IP_Configuration_Profiles
{
    public partial class FormEdit : Form
    {
        string interfaceName, profileName, ipAddress, netmask, gateway, dns1, dns2;

        bool editProfile;

        List<object> formInputs;

        NetworkProfile profileToEdit;

        FormMain main;

        public FormEdit(bool edit, FormMain _main)
        {
            InitializeComponent();
            editProfile = edit;
            main = _main;
        }

        public FormEdit(bool edit, object toEdit, FormMain _main)
        {
            InitializeComponent();
            editProfile = edit;
            profileToEdit = (NetworkProfile)toEdit;
            main = _main;
        }

        public void FormEdit_Load(object sender, EventArgs e)
        {
            formInputs = new List<object>() { tbName, tbIpAddress, tbNetmask, tbGateway, tbDns1, tbDns2};
            LoadInterfaces();

            if (editProfile)
            {
                LoadProfileValues();
            }
        }

        public void LoadProfileValues()
        {
            foreach (object o in formInputs)
            {
                if (o is TextBox)
                {
                    TextBox tb = (TextBox)o;
                    tb.Text = GetPropValue(profileToEdit, tb.Tag.ToString()).ToString();
                }
                else
                {
                    IPAddressControl ip = (IPAddressControl)o;
                    if (GetPropValue(profileToEdit, ip.Tag.ToString()) != null)     // ci vuole sennò esplode
                        ip.Text = GetPropValue(profileToEdit, ip.Tag.ToString()).ToString();
                }
            }

            cbIntefaces.Text = profileToEdit.Interface;
        }

        // ritorna il valore della proprietà cercata
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // aggiunge le schede di reta alla combobox
        public void LoadInterfaces()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                cbIntefaces.Items.Add(nic.Name);
            }
        }

        public void InterfaceSelected(object sender, EventArgs e)
        {
            interfaceName = cbIntefaces.SelectedItem.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            profileName = tbName.Text;
            ipAddress = tbIpAddress.Text;
            netmask = tbNetmask.Text;
            gateway = tbGateway.Text;
            dns1 = tbDns1.Text;
            dns2 = tbDns2.Text;

            if (editProfile)
            {
                EditProfile();
            }
            else
            {
                NewProfile();
            }
        }

        public void EditProfile()
        {
            ProfilesCollection.RemoveProfile(profileToEdit);
            NewProfile();
        }

        public void NewProfile()
        {
            NetworkProfile profile;
            
            if (rdbDhcp.Checked)
            {
                profile = new NetworkProfile(
                    profileName,
                    interfaceName);
            }
            else
            {
                profile = new NetworkProfile(
                    profileName,
                    interfaceName,
                    ipAddress,
                    netmask,
                    gateway,
                    dns1,
                    dns2);
            }

            ProfilesCollection.AddProfile(profile);

            main.UpdateForm();    // refresh dei profili nel main
            this.Close();
        }

        public void ConfigurationModeChanged(object sender, EventArgs e)
        {
            if (rdbDhcp.Checked)
            {
                groupBoxIp.Visible = false;
                groupBoxDns.Visible = false;
            }
            else
            {
                groupBoxIp.Visible = true;
                groupBoxDns.Visible = true;
            }
        }
    }
}
