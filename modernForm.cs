using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace NukUX_ModernUI
{
    public partial class modernForm: UserControl
    {
        private bool IsMaximized;
        private bool isDragging = false; // Boolean to track dragging state
        private Point dragStartPoint = new Point(0, 0); // Store the starting point of the drag
        public modernForm()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            App_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            IsMaximized = false;
            // Handle mouse events for dragging the form
            this.MouseDown += App_ControlBar_MouseDown;
            this.MouseMove += App_ControlBar_MouseMove;
            this.MouseUp += App_ControlBar_MouseUp;
            SetFormCenterScreen();
        }

        public FormWindowState WindowState { get; private set; }

        private void SetFormCenterScreen()
        {
            // Find the parent form of the UserControl
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                // Set the form's start position to center screen
                parentForm.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private void App_CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void App_ControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is pressed
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true; // Set the dragging state to true
                dragStartPoint = new Point(e.X, e.Y); // Store the starting point of the drag
            }
        }

        private void App_ControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the user is dragging the control
            if (isDragging)
            {
                // Find the parent form of the UserControl
                Form parentForm = this.FindForm();

                if (parentForm != null)
                {
                    // Calculate the new location of the form
                    Point newLocation = parentForm.Location;
                    newLocation.X += e.X - dragStartPoint.X;
                    newLocation.Y += e.Y - dragStartPoint.Y;
                    parentForm.Location = newLocation; // Update the form's location
                }
            }
        }

        private void App_ControlBar_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop the dragging action
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false; // Set the dragging state to false
            }
        }


        public string AppTitle
        {
            get { return App_Title.Text; }
            set { App_Title.Text = value; }
        }

        public Image AppIcon
        {
            get { return App_Icon.Image; }
            set { App_Icon.Image = value; }
        }

        private void App_Maximize_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                if (!IsMaximized)
                {
                    // Get the working area of the screen, excluding the taskbar
                    Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

                    // Set the location and size of the parent form to fill the working area
                    parentForm.Location = new Point(workingArea.Left, workingArea.Top);
                    parentForm.Size = new Size(workingArea.Width, workingArea.Height);

                    // Update the button text to indicate the next action (Restore) 
                    ((Button)sender).Text = "❒";

                    // Set IsMaximized to true
                    IsMaximized = true;
                }
                else
                {
                    // Restore the form to its original size
                    parentForm.WindowState = FormWindowState.Normal;

                    // Update the button text back to Maximize
                    ((Button)sender).Text = "▢";
                    parentForm.Size = new Size(1133, 636);
                    // Set IsMaximized to false
                    IsMaximized = false;
                }
            }
        }
    }
    }
 
