using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IP_Configuration_Profiles
{
    /*
     * TODO
     * 
     * - Niente, yayy
     */

    public partial class FormMain : Form
    {
        NetworkProfile selectedProfile;

        string anotherInterface;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateForm();
            LoadInterfaces();
        }

        #region Cose

        public void UpdateForm()
        {
            buttonApply.Enabled = false;
            buttonEdit.Enabled = false;
            cbAnotherNic.Enabled = false;
            cbIntefaces.Enabled = false;

            boxProfiles.Items.Clear();

            foreach (NetworkProfile p in ProfilesCollection.Profiles)
                boxProfiles.Items.Add(p.Name);

            dataGridView.DataSource = null;
        }

        #endregion

        #region Input utente

        // profilo selezionato
        private void ProfileSelected(object sender, EventArgs e)
        {
            if (boxProfiles.SelectedItem != null)
            {
                buttonApply.Enabled = true;
                buttonEdit.Enabled = true;
                cbAnotherNic.Enabled = true;

                var item = ProfilesCollection.Profiles.FirstOrDefault(p => p.Name == boxProfiles.SelectedItem.ToString());
                selectedProfile = item;

                ShowProfile(selectedProfile);
            }
        }

        // edita profilo esistente
        public void EditProfile(object sender, EventArgs e)
        {
            FormEdit edit = new FormEdit(true, selectedProfile, this);
            edit.ShowDialog();
        }

        public void NewProfile(object sender, EventArgs e)
        {
            FormEdit edit = new FormEdit(false, this);
            edit.ShowDialog();
        }

        // rimuove il profilo selezionato
        public void RemoveProfile(object sender, EventArgs e)
        {
            ProfilesCollection.RemoveProfile(selectedProfile);
            UpdateForm();
        }

        // applica profilo selezionato
        public void ApplyProfile(object sender, EventArgs e)
        {
            if (selectedProfile != null)
            {
                if (cbAnotherNic.Checked)       
                {
                    selectedProfile.ApplyToAnotherInterface(anotherInterface);
                }
                else
                {
                    selectedProfile.Apply();
                }
            }
        }

        // checkbox applica profilo su altra nic
        private void cbAnotherNic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnotherNic.Checked)
            {
                cbIntefaces.Enabled = true;
            }
            else
            {
                cbIntefaces.Enabled = false;
            }
        }

        // selezione interfaccia
        private void cbIntefaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            anotherInterface = cbIntefaces.SelectedItem.ToString();
        }

        #endregion

        #region Output 

        // carica le nic disponibili
        public void LoadInterfaces()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface nic in nics)
            {
                cbIntefaces.Items.Add(nic.Name);
            }
        }

        // mostra il profilo selezionato nel datagrid
        public void ShowProfile(object p)
        {
            NetworkProfile profile = (NetworkProfile)p;

            DataTable t = new DataTable();
            t.Columns.Add("Nome");
            t.Columns.Add("Valore");
            t.Rows.Add("Nome profilo", profile.Name);
            t.Rows.Add("Interfaccia", profile.Interface);
            t.Rows.Add("Indirizzo IP", profile.IPAddress);
            t.Rows.Add("Netmask", profile.Netmask);
            t.Rows.Add("Gateway", profile.Gateway);
            t.Rows.Add("DNS 1", profile.DNS1);
            t.Rows.Add("DNS 2", profile.DNS2);

            dataGridView.DataSource = t;
        }

        #endregion
    }
}
