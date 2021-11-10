
namespace Zork.Builder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.ToolStripMenuItem fileMenu;
            System.Windows.Forms.ToolStripSeparator fileSeperatorMenu;
            System.Windows.Forms.ToolStripMenuItem exitMenu;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label startingLabel;
            this.newMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.southNeighborControl = new Zork.Builder.NeighborControl();
            this.eastNeighborControl = new Zork.Builder.NeighborControl();
            this.westNeighborControl = new Zork.Builder.NeighborControl();
            this.northNeighborControl = new Zork.Builder.NeighborControl();
            this.roomDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.startingComboBox = new System.Windows.Forms.ComboBox();
            this.startBindingSource = new System.Windows.Forms.BindingSource(this.components);
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            fileSeperatorMenu = new System.Windows.Forms.ToolStripSeparator();
            exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            roomNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            startingLabel = new System.Windows.Forms.Label();
            mainMenuStrip.SuspendLayout();
            this.roomInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.roomsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileMenu});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(542, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "MainMenuStrip";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenu,
            this.openMenu,
            this.closeGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            fileSeperatorMenu,
            exitMenu});
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new System.Drawing.Size(37, 20);
            fileMenu.Text = "&File";
            // 
            // newMenu
            // 
            this.newMenu.Name = "newMenu";
            this.newMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenu.Size = new System.Drawing.Size(146, 22);
            this.newMenu.Text = "&New";
            this.newMenu.Click += new System.EventHandler(this.newMenu_Click);
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenu.Size = new System.Drawing.Size(146, 22);
            this.openMenu.Text = "&Open";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // closeGameToolStripMenuItem
            // 
            this.closeGameToolStripMenuItem.Enabled = false;
            this.closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            this.closeGameToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeGameToolStripMenuItem.Text = "&Close Game";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // fileSeperatorMenu
            // 
            fileSeperatorMenu.Name = "fileSeperatorMenu";
            fileSeperatorMenu.Size = new System.Drawing.Size(143, 6);
            // 
            // exitMenu
            // 
            exitMenu.Name = "exitMenu";
            exitMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            exitMenu.Size = new System.Drawing.Size(146, 22);
            exitMenu.Text = "&Exit";
            exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(6, 20);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(35, 13);
            roomNameLabel.TabIndex = 0;
            roomNameLabel.Text = "&Name";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(6, 86);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(60, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description";
            // 
            // startingLabel
            // 
            startingLabel.AutoSize = true;
            startingLabel.Location = new System.Drawing.Point(15, 469);
            startingLabel.Name = "startingLabel";
            startingLabel.Size = new System.Drawing.Size(87, 13);
            startingLabel.TabIndex = 3;
            startingLabel.Text = "Starting Location";
            // 
            // roomInfoGroupBox
            // 
            this.roomInfoGroupBox.Controls.Add(this.southNeighborControl);
            this.roomInfoGroupBox.Controls.Add(this.eastNeighborControl);
            this.roomInfoGroupBox.Controls.Add(this.westNeighborControl);
            this.roomInfoGroupBox.Controls.Add(this.northNeighborControl);
            this.roomInfoGroupBox.Controls.Add(this.roomDescriptionTextBox);
            this.roomInfoGroupBox.Controls.Add(descriptionLabel);
            this.roomInfoGroupBox.Controls.Add(this.roomNameTextBox);
            this.roomInfoGroupBox.Controls.Add(roomNameLabel);
            this.roomInfoGroupBox.Location = new System.Drawing.Point(241, 27);
            this.roomInfoGroupBox.Name = "roomInfoGroupBox";
            this.roomInfoGroupBox.Size = new System.Drawing.Size(288, 522);
            this.roomInfoGroupBox.TabIndex = 2;
            this.roomInfoGroupBox.TabStop = false;
            // 
            // southNeighborControl
            // 
            this.southNeighborControl.Direction = Zork.Directions.South;
            this.southNeighborControl.Location = new System.Drawing.Point(80, 390);
            this.southNeighborControl.Name = "southNeighborControl";
            this.southNeighborControl.Neighbor = null;
            this.southNeighborControl.Room = null;
            this.southNeighborControl.Rooms = null;
            this.southNeighborControl.Size = new System.Drawing.Size(129, 57);
            this.southNeighborControl.TabIndex = 7;
            // 
            // eastNeighborControl
            // 
            this.eastNeighborControl.Direction = Zork.Directions.East;
            this.eastNeighborControl.Location = new System.Drawing.Point(153, 331);
            this.eastNeighborControl.Name = "eastNeighborControl";
            this.eastNeighborControl.Neighbor = null;
            this.eastNeighborControl.Room = null;
            this.eastNeighborControl.Rooms = null;
            this.eastNeighborControl.Size = new System.Drawing.Size(129, 57);
            this.eastNeighborControl.TabIndex = 6;
            // 
            // westNeighborControl
            // 
            this.westNeighborControl.Direction = Zork.Directions.West;
            this.westNeighborControl.Location = new System.Drawing.Point(6, 331);
            this.westNeighborControl.Name = "westNeighborControl";
            this.westNeighborControl.Neighbor = null;
            this.westNeighborControl.Room = null;
            this.westNeighborControl.Rooms = null;
            this.westNeighborControl.Size = new System.Drawing.Size(130, 57);
            this.westNeighborControl.TabIndex = 5;
            // 
            // northNeighborControl
            // 
            this.northNeighborControl.Direction = Zork.Directions.North;
            this.northNeighborControl.Location = new System.Drawing.Point(80, 268);
            this.northNeighborControl.Name = "northNeighborControl";
            this.northNeighborControl.Neighbor = null;
            this.northNeighborControl.Room = null;
            this.northNeighborControl.Rooms = null;
            this.northNeighborControl.Size = new System.Drawing.Size(129, 57);
            this.northNeighborControl.TabIndex = 4;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(6, 102);
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(276, 114);
            this.roomDescriptionTextBox.TabIndex = 3;
            this.roomDescriptionTextBox.Text = "";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.AllowNew = true;
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.GameViewModel);
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameTextBox.Location = new System.Drawing.Point(6, 36);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(276, 20);
            this.roomNameTextBox.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON Files|*.json";
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.addRoomButton);
            this.roomsGroupBox.Controls.Add(this.roomsListBox);
            this.roomsGroupBox.Controls.Add(this.deleteRoomButton);
            this.roomsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(222, 419);
            this.roomsGroupBox.TabIndex = 1;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Rooms";
            // 
            // addRoomButton
            // 
            this.addRoomButton.Enabled = false;
            this.addRoomButton.Location = new System.Drawing.Point(60, 390);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 1;
            this.addRoomButton.Text = "&Add";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(6, 20);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(210, 368);
            this.roomsListBox.TabIndex = 0;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.roomsListBox_SelectedIndexChanged);
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Enabled = false;
            this.deleteRoomButton.Location = new System.Drawing.Point(141, 390);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 2;
            this.deleteRoomButton.Text = "&Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JSON Files|*.json";
            // 
            // startingComboBox
            // 
            this.startingComboBox.DataSource = this.startBindingSource;
            this.startingComboBox.DisplayMember = "Name";
            this.startingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startingComboBox.FormattingEnabled = true;
            this.startingComboBox.Location = new System.Drawing.Point(18, 485);
            this.startingComboBox.Name = "startingComboBox";
            this.startingComboBox.Size = new System.Drawing.Size(210, 21);
            this.startingComboBox.TabIndex = 5;
            this.startingComboBox.ValueMember = "Description";
            this.startingComboBox.SelectedIndexChanged += new System.EventHandler(this.startingComboBox_SelectedIndexChanged);
            // 
            // startBindingSource
            // 
            this.startBindingSource.DataMember = "Rooms";
            this.startBindingSource.DataSource = this.gameViewModelBindingSource;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 561);
            this.Controls.Add(this.startingComboBox);
            this.Controls.Add(startingLabel);
            this.Controls.Add(this.roomInfoGroupBox);
            this.Controls.Add(this.roomsGroupBox);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Zork Builder";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            this.roomInfoGroupBox.ResumeLayout(false);
            this.roomInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.roomsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.startBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.ToolStripMenuItem newMenu;
        private System.Windows.Forms.ToolStripMenuItem closeGameToolStripMenuItem;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.RichTextBox roomDescriptionTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox roomInfoGroupBox;
        private NeighborControl southNeighborControl;
        private NeighborControl eastNeighborControl;
        private NeighborControl westNeighborControl;
        private NeighborControl northNeighborControl;
        private System.Windows.Forms.ComboBox startingComboBox;
        private System.Windows.Forms.BindingSource startBindingSource;
    }
}

