using System.Drawing.Text;

namespace TermProjectPartOne
{
    public partial class FarmDashBoard : Form
    {
        private int droneX = 0;
        private int droneY = 0;
        private bool scanning = false;

        public FarmDashBoard()
        {
            InitializeComponent();

            CommandsDropBox.Items.Add("Rename");
            CommandsDropBox.Items.Add("Change Location");
            CommandsDropBox.Items.Add("Change Price");
            CommandsDropBox.Items.Add("Change Dimensions");
            CommandsDropBox.Items.Add("Delete");

            // Wire up the SelectedIndexChanged event
            CommandsDropBox.SelectedIndexChanged += CommandsDropBox_SelectedIndexChanged;

            CommandsContainersDropBox.Items.Add("Rename");
            CommandsContainersDropBox.Items.Add("Change Location");
            CommandsContainersDropBox.Items.Add("Change Price");
            CommandsContainersDropBox.Items.Add("Change Dimensions");
            CommandsContainersDropBox.Items.Add("Add Item");
            CommandsContainersDropBox.Items.Add("Add Item-Container");
            CommandsContainersDropBox.Items.Add("Delete");

            // Wire up the SelectedIndexChanged event
            CommandsContainersDropBox.SelectedIndexChanged += CommandsContainersDropBox_SelectedIndexChanged;

            ScanFarmButton.CheckedChanged += ScanFarmButton_CheckedChanged;


        }


        private void CropImage_Click(object sender, EventArgs e)
        {

        }

        private void FarmDashboardTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CropImage2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundVisual_Click(object sender, EventArgs e)
        {

        }

        private void FarmImage_Click(object sender, EventArgs e)
        {

        }

        private void CommandCenterImage_Click(object sender, EventArgs e)
        {

        }

        private void CommandsContainersDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string selectedCommand = comboBox.SelectedItem.ToString();

                // Perform actions based on the selected command
                switch (selectedCommand)
                {
                    case "Rename":
                        // Implement logic for Rename command
                        break;

                    case "Change Location":
                        // Implement logic for Change Location command
                        break;

                    case "Change Price":
                        // Implement logic for Change Price command
                        break;

                    case "Change Dimensions":
                        // Implement logic for Change Dimensions command
                        break;

                    case "Add Item":
                        // Implement logic for Add Item command
                        break;

                    case "Add Item-Container":
                        // Implement logic for Add Item-Container command
                        break;

                    case "Delete":
                        // Implement logic for Delete command
                        break;

                    default:
                        break;
                }
            }
        }


        private void CommandsDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                string selectedCommand = comboBox.SelectedItem.ToString();

                // Perform actions based on the selected command
                switch (selectedCommand)
                {
                    case "Rename":
                        // Implement logic for Rename command
                        break;

                    case "Change Location":
                        // Implement logic for Change Location command
                        break;

                    case "Change Price":
                        // Implement logic for Change Price command
                        break;

                    case "Change Dimensions":
                        // Implement logic for Change Dimensions command
                        break;

                    case "Delete":
                        // Implement logic for Delete command
                        break;

                    default:
                        break;
                }
            }
        }


        private void ItemTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void ItemPanelTitle_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = "1. Items / Item Containers";
                textBox.Font = new Font("Arial Narrow", 16, FontStyle.Bold);
            }
        }

        private void ArduinoDeviceActionsTitle_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = "3. Arduino/Microbit Controlled Device Actions";
                textBox.Font = new Font("Arial Narrow", 16, FontStyle.Bold);
            }
        }

        private void VisitItemButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ScanFarmButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ScanFarmButton.Checked)
            {
                scanning = true;

                droneMovement();
            }
            else
            {

                scanning = false;

            }
        }
        private void ResetDronePosition()
        {
            droneX = 0;
            droneY = 0;
        }

        private void droneMovement()
        {
            if (scanning)
            {


                // Move to the right
                droneX += 350;
                panel1.Invalidate();
                Task.Delay(1000).Wait(); // Add a delay

                // Move down a little
                droneY += 10;
                panel1.Invalidate();
                Task.Delay(1000).Wait(); // Add a delay

                // Move all the way to the left
                droneX -= 350;
                panel1.Invalidate();
                Task.Delay(1000).Wait(); // Add a delay

                // Move down a little
                droneY += 10;
                panel1.Invalidate();
                Task.Delay(1000).Wait(); // Add a delay

                // Continue the pattern until reaching the bottom of the panel
                if (droneY < panel1.Height)
                {
                    droneMovement();
                }
                else
                {
                    // Stop scanning when reaching the bottom
                    scanning = false;

                }
            }

        }
        private void ItemsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ArduinoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Drone_Click(object sender, EventArgs e)
        {

        }

        private void VisualizationTitle_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.Text = "2. Visualization";
                textBox.Font = new Font("Arial Narrow", 16, FontStyle.Bold);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            int visualizationWidth = 800;
            int visualizationHeight = 600;

            e.Graphics.DrawImage(CropImage2.Image, ScaleX(CropImage2.Location.X), ScaleY(CropImage2.Location.Y), 261, 286);
            e.Graphics.DrawImage(CropImage.Image, ScaleX(CropImage.Location.X), ScaleY(CropImage.Location.Y), 261, 269);
            e.Graphics.DrawImage(FarmImage.Image, ScaleX(FarmImage.Location.X), ScaleY(FarmImage.Location.Y), 199, 159);
            e.Graphics.DrawImage(CommandCenterImage.Image, ScaleX(CommandCenterImage.Location.X), ScaleY(CommandCenterImage.Location.Y), 191, 171);

            if (scanning)
            {
                e.Graphics.DrawImage(Drone.Image, droneX, droneY, 100, 50);
            }

        }

        private int ScaleX(int x)
        {
            return (int)((double)x / panel1.Width * 800);
        }

        private int ScaleY(int y)
        {
            return (int)((double)y / panel1.Height * 600);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetDronePosition();
            panel1.Invalidate();
        }
    }
}