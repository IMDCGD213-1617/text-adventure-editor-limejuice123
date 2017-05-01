using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace RoomBuilder
{
    public partial class program : Form
    {
        public program()
        {
            InitializeComponent();
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            ItemsInRoom.Items.Add(ItemToAdd.Text);
            ItemToAdd.Text = "";
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            ItemsInRoom.Items.Remove(ItemsInRoom.SelectedItem);
        }

        private void addUsable_Click(object sender, EventArgs e)
        {
            UsablesInRoom.Items.Add(UsableToAdd.Text);
            UsableToAdd.Text = "";
        }

        private void RemoveUsables_Click(object sender, EventArgs e)
        {
            UsablesInRoom.Items.Remove(UsablesInRoom.SelectedItem);
        }

        private void addLocation_Click(object sender, EventArgs e)
        {
            Output currentLocation = new Output();

            currentLocation.RoomDescription = roomDescription.Text;
            currentLocation.RoomTitle = roomTitle.Text;

            for (int i = 0; i < ItemsInRoom.Items.Count; i++)
            {
                currentLocation.ItemsInRoom.Add(ItemsInRoom.Items[i].ToString());
            }

            for (int x = 0; x < UsablesInRoom.Items.Count; x++)
            {
                currentLocation.UsablesInRoom.Add(UsablesInRoom.Items[x].ToString());
            }

            for (int i = 0; i < ExitsList.Items.Count; i++)
            {
                if (ExitsList.GetItemChecked(i))
                {
                    currentLocation.ExitsInRoom.Add(ExitsList.GetItemText(ExitsList.Items[i]));
                }
            }
           
            XmlSerializer ser = new XmlSerializer(typeof(Output));

            try
            {
                TextWriter tw = new StreamWriter("location.xml");
                ser.Serialize(tw, currentLocation);
                tw.Close();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error: File in use", "Room Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ItemToAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }

            ItemsInRoom.Items.Add(ItemToAdd.Text);
            ItemToAdd.Clear();
        }

        private void UsableToAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Enter)
            {
                return;
            }

            UsablesInRoom.Items.Add(UsableToAdd.Text);
            UsableToAdd.Clear();
        }
    }
}
