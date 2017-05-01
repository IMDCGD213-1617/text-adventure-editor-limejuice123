using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//System.Xml.Serialization allows me to use the StreamWriter that will convert the output to XML 
using System.Xml.Serialization;
//System.IO allows reading and writing to files
using System.IO;

namespace RoomBuilder
{
    public partial class program : Form
    {
        public program()
        {
            InitializeComponent();
        }

        //When addItem is clicked, move whatever was in the text box above to the listbox.
        private void addItem_Click(object sender, EventArgs e)
        {
            ItemsInRoom.Items.Add(ItemToAdd.Text);
            ItemToAdd.Text = "";
        }

        //Remove the highlighted item from the listbox.
        private void RemoveItem_Click(object sender, EventArgs e)
        {
            ItemsInRoom.Items.Remove(ItemsInRoom.SelectedItem);
        }

        //When addUsable is clicked, move whatever was in the text box above to the listbox.
        private void addUsable_Click(object sender, EventArgs e)
        {
            UsablesInRoom.Items.Add(UsableToAdd.Text);
            UsableToAdd.Text = "";
        }

        //Remove the highlighted item from the listbox.
        private void RemoveUsables_Click(object sender, EventArgs e)
        {
            UsablesInRoom.Items.Remove(UsablesInRoom.SelectedItem);
        }

        //Outputs all the location details to an xml file.
        private void addLocation_Click(object sender, EventArgs e)
        {
            //Declare an instance of the output class for outputting.
            Output currentLocation = new Output();

            //Add the room title and description to the class instance.
            currentLocation.RoomDescription = roomDescription.Text;
            currentLocation.RoomTitle = roomTitle.Text;

            //Get all the items of the ItemsInRoom listbox and add them to a list<string> for output.
            for (int i = 0; i < ItemsInRoom.Items.Count; i++)
            {
                currentLocation.ItemsInRoom.Add(ItemsInRoom.Items[i].ToString());
            }

            //Get all the items of the UsablesInRoom listbox and add them to a different list<string> for output.
            for (int x = 0; x < UsablesInRoom.Items.Count; x++)
            {
                currentLocation.UsablesInRoom.Add(UsablesInRoom.Items[x].ToString());
            }

            //Get all the selected items in the Exits CheckboxList and add the text from the item to a list<string> for output.
            for (int i = 0; i < ExitsList.Items.Count; i++)
            {
                //This if statement makes sure to get only the items that are currently checked.
                if (ExitsList.GetItemChecked(i))
                {
                    currentLocation.ExitsInRoom.Add(ExitsList.GetItemText(ExitsList.Items[i]));
                }
            }

            //An XML Serializer is used to change the instance of the output class to XML. In this case, I am telling the program to serialise the Output() class in Program.cs
            XmlSerializer ser = new XmlSerializer(typeof(Output));

            try
            {
                //A TextWriter is a class that can write/output a series of characters. A StreamWriter allows outputting of whole lines of text rather than individual characters.
                TextWriter tw = new StreamWriter("location.xml");
                //Here we convert currentLocation (which is an instance of Output()) to XML, and output it using the StreamWriter tw to a new file "location.xml"
                ser.Serialize(tw, currentLocation);
                //Then we close tw so we can alter/delete/create the file again without having to close the application.
                tw.Close();
            }
            //This try/catch ensures that the program does not attempt to open or alter the stream whilst it is in use, as this will cause a crash.
            catch (System.IO.IOException)
            {
                MessageBox.Show("Error: File in use", "Room Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //This method allows the user to use the enter key to add an item to the listbox, rather than pressing the button manually.
        private void ItemToAdd_KeyDown(object sender, KeyEventArgs e)
        {
            //if the user presses a key that isn't enter
            if (e.KeyCode != Keys.Enter)
            {
                //Don't do anything.
                return;
            }

            ItemsInRoom.Items.Add(ItemToAdd.Text);
            ItemToAdd.Clear();
        }

        //This method is the same as the above, but for usables.
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
