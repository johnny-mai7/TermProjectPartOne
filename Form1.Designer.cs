namespace TermProjectPartOne
{
    partial class FarmDashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("Root");
            TreeNode treeNode2 = new TreeNode("Barn");
            TreeNode treeNode3 = new TreeNode("Live-Stock-Area");
            TreeNode treeNode4 = new TreeNode("Cow");
            TreeNode treeNode5 = new TreeNode("Milk-Storage");
            TreeNode treeNode6 = new TreeNode("Command-Center");
            TreeNode treeNode7 = new TreeNode("Drone");
            TreeNode treeNode8 = new TreeNode("Crop");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmDashBoard));
            ItemsPanel = new Panel();
            ItemTreeView = new TreeView();
            CommandsContainersDropBox = new ComboBox();
            CommandsDropBox = new ComboBox();
            ItemPanelTitle = new TextBox();
            ArduinoPanel = new Panel();
            ResetButton = new Button();
            ScanFarmButton = new RadioButton();
            VisitItemButton = new RadioButton();
            ArduinoDeviceActionsTitle = new TextBox();
            panel1 = new Panel();
            Drone = new PictureBox();
            FarmImage = new PictureBox();
            CropImage2 = new PictureBox();
            CropImage = new PictureBox();
            VisualizationTitle = new TextBox();
            CommandCenterImage = new PictureBox();
            FarmDashboardTitle = new TextBox();
            ItemsPanel.SuspendLayout();
            ArduinoPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Drone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FarmImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CropImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CropImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommandCenterImage).BeginInit();
            SuspendLayout();
            // 
            // ItemsPanel
            // 
            ItemsPanel.Controls.Add(ItemTreeView);
            ItemsPanel.Controls.Add(CommandsContainersDropBox);
            ItemsPanel.Controls.Add(CommandsDropBox);
            ItemsPanel.Controls.Add(ItemPanelTitle);
            ItemsPanel.Location = new Point(12, 39);
            ItemsPanel.Name = "ItemsPanel";
            ItemsPanel.Size = new Size(363, 463);
            ItemsPanel.TabIndex = 0;
            ItemsPanel.Paint += ItemsPanel_Paint;
            // 
            // ItemTreeView
            // 
            ItemTreeView.Location = new Point(3, 45);
            ItemTreeView.Name = "ItemTreeView";
            treeNode1.Name = "Node0";
            treeNode1.NodeFont = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            treeNode1.Text = "Root";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Barn";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Live-Stock-Area";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Cow";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Milk-Storage";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Command-Center";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Drone";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Crop";
            ItemTreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7, treeNode8 });
            ItemTreeView.Size = new Size(183, 169);
            ItemTreeView.TabIndex = 2;
            ItemTreeView.AfterSelect += ItemTreeView_AfterSelect;
            // 
            // CommandsContainersDropBox
            // 
            CommandsContainersDropBox.BackColor = SystemColors.Menu;
            CommandsContainersDropBox.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CommandsContainersDropBox.FormattingEnabled = true;
            CommandsContainersDropBox.Location = new Point(137, 220);
            CommandsContainersDropBox.Name = "CommandsContainersDropBox";
            CommandsContainersDropBox.Size = new Size(211, 28);
            CommandsContainersDropBox.TabIndex = 2;
            CommandsContainersDropBox.Text = "Commands on Item Containers";
            CommandsContainersDropBox.SelectedIndexChanged += CommandsContainersDropBox_SelectedIndexChanged;
            // 
            // CommandsDropBox
            // 
            CommandsDropBox.BackColor = SystemColors.Menu;
            CommandsDropBox.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CommandsDropBox.FormattingEnabled = true;
            CommandsDropBox.Location = new Point(192, 45);
            CommandsDropBox.Name = "CommandsDropBox";
            CommandsDropBox.Size = new Size(156, 28);
            CommandsDropBox.TabIndex = 1;
            CommandsDropBox.Text = "Commands on Items";
            CommandsDropBox.SelectedIndexChanged += CommandsDropBox_SelectedIndexChanged;
            // 
            // ItemPanelTitle
            // 
            ItemPanelTitle.BackColor = SystemColors.Menu;
            ItemPanelTitle.BorderStyle = BorderStyle.None;
            ItemPanelTitle.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ItemPanelTitle.Location = new Point(3, 3);
            ItemPanelTitle.Name = "ItemPanelTitle";
            ItemPanelTitle.ReadOnly = true;
            ItemPanelTitle.Size = new Size(324, 25);
            ItemPanelTitle.TabIndex = 0;
            ItemPanelTitle.Text = "1. Items/Item Containers";
            ItemPanelTitle.TextChanged += ItemPanelTitle_TextChanged;
            // 
            // ArduinoPanel
            // 
            ArduinoPanel.Controls.Add(ResetButton);
            ArduinoPanel.Controls.Add(ScanFarmButton);
            ArduinoPanel.Controls.Add(VisitItemButton);
            ArduinoPanel.Controls.Add(ArduinoDeviceActionsTitle);
            ArduinoPanel.Location = new Point(12, 508);
            ArduinoPanel.Name = "ArduinoPanel";
            ArduinoPanel.Size = new Size(363, 183);
            ArduinoPanel.TabIndex = 0;
            ArduinoPanel.Paint += ArduinoPanel_Paint;
            // 
            // ResetButton
            // 
            ResetButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ResetButton.Location = new Point(32, 119);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(84, 33);
            ResetButton.TabIndex = 3;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // ScanFarmButton
            // 
            ScanFarmButton.AutoSize = true;
            ScanFarmButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ScanFarmButton.Location = new Point(32, 89);
            ScanFarmButton.Name = "ScanFarmButton";
            ScanFarmButton.Size = new Size(94, 24);
            ScanFarmButton.TabIndex = 2;
            ScanFarmButton.TabStop = true;
            ScanFarmButton.Text = "Scan Farm";
            ScanFarmButton.UseVisualStyleBackColor = true;
            ScanFarmButton.CheckedChanged += ScanFarmButton_CheckedChanged;
            // 
            // VisitItemButton
            // 
            VisitItemButton.AutoSize = true;
            VisitItemButton.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VisitItemButton.Location = new Point(32, 59);
            VisitItemButton.Name = "VisitItemButton";
            VisitItemButton.Size = new Size(189, 24);
            VisitItemButton.TabIndex = 1;
            VisitItemButton.TabStop = true;
            VisitItemButton.Text = "Visit Item / Item Container";
            VisitItemButton.UseVisualStyleBackColor = true;
            VisitItemButton.CheckedChanged += VisitItemButton_CheckedChanged;
            // 
            // ArduinoDeviceActionsTitle
            // 
            ArduinoDeviceActionsTitle.BackColor = SystemColors.Menu;
            ArduinoDeviceActionsTitle.BorderStyle = BorderStyle.None;
            ArduinoDeviceActionsTitle.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ArduinoDeviceActionsTitle.Location = new Point(3, 3);
            ArduinoDeviceActionsTitle.Name = "ArduinoDeviceActionsTitle";
            ArduinoDeviceActionsTitle.Size = new Size(357, 22);
            ArduinoDeviceActionsTitle.TabIndex = 0;
            ArduinoDeviceActionsTitle.Text = "3. Arduino / Microbit Controlled Device Actions ";
            ArduinoDeviceActionsTitle.TextChanged += ArduinoDeviceActionsTitle_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(Drone);
            panel1.Controls.Add(FarmImage);
            panel1.Controls.Add(CropImage2);
            panel1.Controls.Add(CropImage);
            panel1.Controls.Add(VisualizationTitle);
            panel1.Controls.Add(CommandCenterImage);
            panel1.Location = new Point(390, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 652);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Drone
            // 
            Drone.Image = (Image)resources.GetObject("Drone.Image");
            Drone.Location = new Point(479, 3);
            Drone.Name = "Drone";
            Drone.Size = new Size(10, 10);
            Drone.SizeMode = PictureBoxSizeMode.StretchImage;
            Drone.TabIndex = 6;
            Drone.TabStop = false;
            Drone.Click += Drone_Click;
            // 
            // FarmImage
            // 
            FarmImage.Image = (Image)resources.GetObject("FarmImage.Image");
            FarmImage.Location = new Point(23, 472);
            FarmImage.Name = "FarmImage";
            FarmImage.Size = new Size(199, 159);
            FarmImage.SizeMode = PictureBoxSizeMode.StretchImage;
            FarmImage.TabIndex = 3;
            FarmImage.TabStop = false;
            FarmImage.Visible = false;
            FarmImage.Click += FarmImage_Click;
            // 
            // CropImage2
            // 
            CropImage2.BackColor = Color.Transparent;
            CropImage2.BackgroundImage = (Image)resources.GetObject("CropImage2.BackgroundImage");
            CropImage2.Image = (Image)resources.GetObject("CropImage2.Image");
            CropImage2.Location = new Point(228, 88);
            CropImage2.Name = "CropImage2";
            CropImage2.Size = new Size(261, 286);
            CropImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            CropImage2.TabIndex = 4;
            CropImage2.TabStop = false;
            CropImage2.Visible = false;
            CropImage2.Click += CropImage2_Click;
            // 
            // CropImage
            // 
            CropImage.BackColor = Color.Transparent;
            CropImage.Image = (Image)resources.GetObject("CropImage.Image");
            CropImage.Location = new Point(228, 380);
            CropImage.Name = "CropImage";
            CropImage.Size = new Size(261, 269);
            CropImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CropImage.TabIndex = 3;
            CropImage.TabStop = false;
            CropImage.Visible = false;
            CropImage.Click += CropImage_Click;
            // 
            // VisualizationTitle
            // 
            VisualizationTitle.BackColor = Color.FromArgb(128, 64, 0);
            VisualizationTitle.BorderStyle = BorderStyle.None;
            VisualizationTitle.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            VisualizationTitle.Location = new Point(12, 4);
            VisualizationTitle.Name = "VisualizationTitle";
            VisualizationTitle.ReadOnly = true;
            VisualizationTitle.Size = new Size(143, 25);
            VisualizationTitle.TabIndex = 1;
            VisualizationTitle.Text = "2. Visualization";
            VisualizationTitle.TextChanged += VisualizationTitle_TextChanged;
            // 
            // CommandCenterImage
            // 
            CommandCenterImage.Image = (Image)resources.GetObject("CommandCenterImage.Image");
            CommandCenterImage.Location = new Point(12, 45);
            CommandCenterImage.Name = "CommandCenterImage";
            CommandCenterImage.Size = new Size(191, 171);
            CommandCenterImage.SizeMode = PictureBoxSizeMode.StretchImage;
            CommandCenterImage.TabIndex = 5;
            CommandCenterImage.TabStop = false;
            CommandCenterImage.Visible = false;
            CommandCenterImage.Click += CommandCenterImage_Click;
            // 
            // FarmDashboardTitle
            // 
            FarmDashboardTitle.BackColor = SystemColors.Menu;
            FarmDashboardTitle.BorderStyle = BorderStyle.None;
            FarmDashboardTitle.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FarmDashboardTitle.Location = new Point(340, 7);
            FarmDashboardTitle.Name = "FarmDashboardTitle";
            FarmDashboardTitle.ReadOnly = true;
            FarmDashboardTitle.Size = new Size(134, 22);
            FarmDashboardTitle.TabIndex = 1;
            FarmDashboardTitle.Text = "Farm Dashboard";
            FarmDashboardTitle.TextChanged += FarmDashboardTitle_TextChanged;
            // 
            // FarmDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 718);
            Controls.Add(FarmDashboardTitle);
            Controls.Add(panel1);
            Controls.Add(ArduinoPanel);
            Controls.Add(ItemsPanel);
            Name = "FarmDashBoard";
            Text = "Form1";
            Load += Form1_Load;
            ItemsPanel.ResumeLayout(false);
            ItemsPanel.PerformLayout();
            ArduinoPanel.ResumeLayout(false);
            ArduinoPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Drone).EndInit();
            ((System.ComponentModel.ISupportInitialize)FarmImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)CropImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CropImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)CommandCenterImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ItemsPanel;
        private Panel ArduinoPanel;
        private Panel panel1;
        private TextBox ItemPanelTitle;
        private TextBox FarmDashboardTitle;
        private TextBox VisualizationTitle;
        private ComboBox CommandsDropBox;
        private ComboBox CommandsContainersDropBox;
        private TextBox ArduinoDeviceActionsTitle;
        private TreeView ItemTreeView;
        private PictureBox CropImage;
        private PictureBox CropImage2;
        private PictureBox FarmImage;
        private RadioButton ScanFarmButton;
        private RadioButton VisitItemButton;
        private PictureBox Drone;
        private PictureBox CommandCenterImage;
        private Button ResetButton;
    }
}