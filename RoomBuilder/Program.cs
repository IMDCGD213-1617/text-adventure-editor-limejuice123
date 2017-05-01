using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBuilder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new program());
        }
    }

    //This is the class that we will print to XML.
    public class Output
    {
        //RoomTitle and RoomDescription have only one value, so they are strings.
        private string _RoomTitle = "";
        private string _RoomDescription = "";

        //All other inputs can have multiple values so they are lists of strings.
        public List<string> ItemsInRoom = new List<string>();
        public List<string> UsablesInRoom = new List<string>();
        public List<string> ExitsInRoom = new List<string>();
      
        public string RoomTitle
        {
            get { return _RoomTitle; }
            set { _RoomTitle = value; }
        }
        public string RoomDescription
        {
            get { return _RoomDescription; }
            set { _RoomDescription = value; }
        }
       
    }
}
