using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using NukUX_ModernUI.UIElements.enumElements;

namespace NukUX_ModernUI
{
    public partial class ModernProgressBar : UserControl
    {
        private int progressValue = 0;
        private Color progressColor = Color.Blue;
        private NukUX_ModernUI.UIElements.enumElements.ProgressBarStyle progressBarStyle = NukUX_ModernUI.UIElements.enumElements.ProgressBarStyle.ProgressVisual;
         

        public ModernProgressBar()
        {
            InitializeComponent(); // Ensure this is called first
            InitializeProgressLabel(); // Initialize the label after InitializeComponent()
            UpdateProgressBar(); // Update the bar to reflect the initial state
        }


        
        // Initialize the progress label
        private void InitializeProgressLabel()
        {
            progressLabel = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Dock = DockStyle.Fill,
                Visible = false // Initially hidden, shown based on ProgressBarStyle
            };
            this.Controls.Add(progressLabel);
            progressLabel.BringToFront(); // Ensure label is on top
        }

        // Property to set the progress value (0-100)
        [Category("Behavior")]
        [Description("The progress value of the ModernProgressBar.")]
        public int ProgressValue
        {
            get { return progressValue; }
            set
            {
                if (value < 0)
                {
                    progressValue = 0;
                }
                else if (value > 100)
                {
                    progressValue = 100;
                }
                else
                {
                    progressValue = value;
                }
                UpdateProgressBar();
            }
        }

        // Property to set the color of the progress bar
        [Category("Appearance")]
        [Description("The color of the ModernProgressBar.")]
        public Color ProgressColor
        {
            get { return progressColor; }
            set
            {
                progressColor = value;
                if (progressBarPanel != null)
                {
                    progressBarPanel.BackColor = progressColor;
                }
            }
        }

        // Property to set the style of the progress bar
        [Category("Appearance")]
        [Description("The style of the ModernProgressBar.")]
        public NukUX_ModernUI.UIElements.enumElements.ProgressBarStyle ProgressBarStyle
        {
            get { return progressBarStyle; }
            set
            {
                progressBarStyle = value;
                UpdateProgressBar();
            }
        }

        // Method to update the progress bar based on the ProgressValue and ProgressBarStyle
        private void UpdateProgressBar()
        {
            if (progressBarPanel == null || progressLabel == null )
            {
                return; // Avoid null reference errors if not properly initialized
            }

            Form parentForm = this.FindForm(); // Get the current modernform
            

            // Fix the problem with modernForm and ModernProgessBar
             

            switch (progressBarStyle)
            {
                case NukUX_ModernUI.UIElements.enumElements.ProgressBarStyle.ProgressVisual:
                    progressBarPanel.Visible = true;
                    progressBarPanel.Width = (int)(this.Width * ((double)progressValue / 100));
                    progressLabel.Visible = false;
                    this.BackColor = SystemColors.Control; // or any other color matching your form
                    break;

                case NukUX_ModernUI.UIElements.enumElements.ProgressBarStyle.ProgressTextOnly: // Delete progressBarPanel and use only ProgressLabel 
                    progressBarPanel.Visible = false;
                    progressBarPanel.Width = 0; // Ensure the panel does not take up space
                    progressLabel.Visible = true;
                    progressLabel.BringToFront(); // Bring the label to the front
                    this.BackColor = SystemColors.Control; // Set to match the parent form's background
                    progressLabel.BackColor = Color.Transparent; // Ensure the label has a transparent background
                    progressLabel.Text = $"{progressValue}%";
                    break;

                case NukUX_ModernUI.UIElements.enumElements.ProgressBarStyle.FullProgress:
                    progressBarPanel.Visible = true;
                    progressBarPanel.Width = (int)(this.Width * ((double)progressValue / 100));
                    progressLabel.Visible = true;
                    progressLabel.BringToFront();
                    this.BackColor = SystemColors.Control; // or any other color that works with FullProgress
                    progressLabel.Text = $"{progressValue}%";
                    break;
            }
        }



        // Override the OnResize method to ensure the progress bar resizes properly
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateProgressBar();
        }
    }
}
