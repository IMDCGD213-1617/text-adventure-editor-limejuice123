namespace RoomBuilder
{
    partial class program
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roomTitle = new System.Windows.Forms.TextBox();
            this.roomTitle_label = new System.Windows.Forms.Label();
            this.roomDescription = new System.Windows.Forms.TextBox();
            this.roomDescription_label = new System.Windows.Forms.Label();
            this.itemsInRoom_label = new System.Windows.Forms.Label();
            this.usablesInRoom_label = new System.Windows.Forms.Label();
            this.addLocation = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.addUsable = new System.Windows.Forms.Button();
            this.ItemsInRoom = new System.Windows.Forms.ListBox();
            this.UsablesInRoom = new System.Windows.Forms.ListBox();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.RemoveUsables = new System.Windows.Forms.Button();
            this.Exits_Label = new System.Windows.Forms.Label();
            this.ExitsList = new System.Windows.Forms.CheckedListBox();
            this.ItemToAdd = new System.Windows.Forms.TextBox();
            this.UsableToAdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // roomTitle
            // 
            this.roomTitle.Location = new System.Drawing.Point(12, 29);
            this.roomTitle.Name = "roomTitle";
            this.roomTitle.Size = new System.Drawing.Size(304, 20);
            this.roomTitle.TabIndex = 0;
            // 
            // roomTitle_label
            // 
            this.roomTitle_label.AutoSize = true;
            this.roomTitle_label.Location = new System.Drawing.Point(9, 9);
            this.roomTitle_label.Name = "roomTitle_label";
            this.roomTitle_label.Size = new System.Drawing.Size(58, 13);
            this.roomTitle_label.TabIndex = 1;
            this.roomTitle_label.Text = "Room Title";
            // 
            // roomDescription
            // 
            this.roomDescription.Location = new System.Drawing.Point(12, 72);
            this.roomDescription.Multiline = true;
            this.roomDescription.Name = "roomDescription";
            this.roomDescription.Size = new System.Drawing.Size(304, 87);
            this.roomDescription.TabIndex = 2;
            // 
            // roomDescription_label
            // 
            this.roomDescription_label.AutoSize = true;
            this.roomDescription_label.Location = new System.Drawing.Point(9, 56);
            this.roomDescription_label.Name = "roomDescription_label";
            this.roomDescription_label.Size = new System.Drawing.Size(91, 13);
            this.roomDescription_label.TabIndex = 3;
            this.roomDescription_label.Text = "Room Description";
            // 
            // itemsInRoom_label
            // 
            this.itemsInRoom_label.AutoSize = true;
            this.itemsInRoom_label.Location = new System.Drawing.Point(12, 168);
            this.itemsInRoom_label.Name = "itemsInRoom_label";
            this.itemsInRoom_label.Size = new System.Drawing.Size(74, 13);
            this.itemsInRoom_label.TabIndex = 5;
            this.itemsInRoom_label.Text = "Items in Room";
            // 
            // usablesInRoom_label
            // 
            this.usablesInRoom_label.AutoSize = true;
            this.usablesInRoom_label.Location = new System.Drawing.Point(169, 170);
            this.usablesInRoom_label.Name = "usablesInRoom_label";
            this.usablesInRoom_label.Size = new System.Drawing.Size(87, 13);
            this.usablesInRoom_label.TabIndex = 7;
            this.usablesInRoom_label.Text = "Usables in Room";
            // 
            // addLocation
            // 
            this.addLocation.Location = new System.Drawing.Point(172, 341);
            this.addLocation.Name = "addLocation";
            this.addLocation.Size = new System.Drawing.Size(133, 49);
            this.addLocation.TabIndex = 8;
            this.addLocation.Text = "Add Location";
            this.addLocation.UseVisualStyleBackColor = true;
            this.addLocation.Click += new System.EventHandler(this.addLocation_Click);
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.Location = new System.Drawing.Point(139, 187);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(26, 23);
            this.addItem.TabIndex = 9;
            this.addItem.Text = "+";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // addUsable
            // 
            this.addUsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsable.Location = new System.Drawing.Point(299, 189);
            this.addUsable.Name = "addUsable";
            this.addUsable.Size = new System.Drawing.Size(25, 23);
            this.addUsable.TabIndex = 10;
            this.addUsable.Text = "+";
            this.addUsable.UseVisualStyleBackColor = true;
            this.addUsable.Click += new System.EventHandler(this.addUsable_Click);
            // 
            // ItemsInRoom
            // 
            this.ItemsInRoom.FormattingEnabled = true;
            this.ItemsInRoom.Location = new System.Drawing.Point(12, 218);
            this.ItemsInRoom.Name = "ItemsInRoom";
            this.ItemsInRoom.Size = new System.Drawing.Size(120, 95);
            this.ItemsInRoom.TabIndex = 11;
            // 
            // UsablesInRoom
            // 
            this.UsablesInRoom.FormattingEnabled = true;
            this.UsablesInRoom.Location = new System.Drawing.Point(173, 218);
            this.UsablesInRoom.Name = "UsablesInRoom";
            this.UsablesInRoom.Size = new System.Drawing.Size(120, 95);
            this.UsablesInRoom.TabIndex = 12;
            // 
            // RemoveItem
            // 
            this.RemoveItem.Location = new System.Drawing.Point(139, 216);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(26, 23);
            this.RemoveItem.TabIndex = 13;
            this.RemoveItem.Text = "-";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // RemoveUsables
            // 
            this.RemoveUsables.Location = new System.Drawing.Point(299, 218);
            this.RemoveUsables.Name = "RemoveUsables";
            this.RemoveUsables.Size = new System.Drawing.Size(25, 23);
            this.RemoveUsables.TabIndex = 14;
            this.RemoveUsables.Text = "-";
            this.RemoveUsables.UseVisualStyleBackColor = true;
            this.RemoveUsables.Click += new System.EventHandler(this.RemoveUsables_Click);
            // 
            // Exits_Label
            // 
            this.Exits_Label.AutoSize = true;
            this.Exits_Label.Location = new System.Drawing.Point(12, 325);
            this.Exits_Label.Name = "Exits_Label";
            this.Exits_Label.Size = new System.Drawing.Size(29, 13);
            this.Exits_Label.TabIndex = 17;
            this.Exits_Label.Text = "Exits";
            // 
            // ExitsList
            // 
            this.ExitsList.BackColor = System.Drawing.SystemColors.Window;
            this.ExitsList.FormattingEnabled = true;
            this.ExitsList.Items.AddRange(new object[] {
            "Forward",
            "Backward",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.ExitsList.Location = new System.Drawing.Point(12, 341);
            this.ExitsList.Name = "ExitsList";
            this.ExitsList.Size = new System.Drawing.Size(120, 94);
            this.ExitsList.TabIndex = 19;
            // 
            // ItemToAdd
            // 
            this.ItemToAdd.Location = new System.Drawing.Point(12, 190);
            this.ItemToAdd.Name = "ItemToAdd";
            this.ItemToAdd.Size = new System.Drawing.Size(117, 20);
            this.ItemToAdd.TabIndex = 20;
            this.ItemToAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemToAdd_KeyDown);
            // 
            // UsableToAdd
            // 
            this.UsableToAdd.Location = new System.Drawing.Point(173, 191);
            this.UsableToAdd.Name = "UsableToAdd";
            this.UsableToAdd.Size = new System.Drawing.Size(120, 20);
            this.UsableToAdd.TabIndex = 21;
            this.UsableToAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsableToAdd_KeyDown);
            // 
            // program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 457);
            this.Controls.Add(this.UsableToAdd);
            this.Controls.Add(this.ItemToAdd);
            this.Controls.Add(this.ExitsList);
            this.Controls.Add(this.Exits_Label);
            this.Controls.Add(this.RemoveUsables);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.UsablesInRoom);
            this.Controls.Add(this.ItemsInRoom);
            this.Controls.Add(this.addUsable);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.addLocation);
            this.Controls.Add(this.usablesInRoom_label);
            this.Controls.Add(this.itemsInRoom_label);
            this.Controls.Add(this.roomDescription_label);
            this.Controls.Add(this.roomDescription);
            this.Controls.Add(this.roomTitle_label);
            this.Controls.Add(this.roomTitle);
            this.Name = "program";
            this.Text = "Add a Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomTitle;
        private System.Windows.Forms.Label roomTitle_label;
        private System.Windows.Forms.TextBox roomDescription;
        private System.Windows.Forms.Label roomDescription_label;
        private System.Windows.Forms.Label itemsInRoom_label;
        private System.Windows.Forms.Label usablesInRoom_label;
        private System.Windows.Forms.Button addLocation;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button addUsable;
        private System.Windows.Forms.ListBox ItemsInRoom;
        private System.Windows.Forms.ListBox UsablesInRoom;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Button RemoveUsables;
        private System.Windows.Forms.Label Exits_Label;
        private System.Windows.Forms.CheckedListBox ExitsList;
        private System.Windows.Forms.TextBox ItemToAdd;
        private System.Windows.Forms.TextBox UsableToAdd;
    }
}

