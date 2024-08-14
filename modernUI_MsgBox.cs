using System;
using System.Drawing;
using System.Windows.Forms;

namespace NukUX_ModernUI
{
    public partial class modernUI_MsgBox : UserControl
    {
        public MsgBoxAction Action { get; private set; }

        public modernUI_MsgBox()
        {
            

            // Set default properties for the UserControl
            this.Size = new Size(400, 200);
            this.BackColor = Color.White;

            // Message label
            Label messageLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 100,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.Black,
                Text = "Your message here"
            };
            this.Controls.Add(messageLabel);

            // OK Button
            Button okButton = new Button
            {
                Text = "OK",
                BackColor = Color.MediumSlateBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 35),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            okButton.FlatAppearance.BorderSize = 0;
            okButton.Location = new Point(this.Width - okButton.Width - 20, this.Height - okButton.Height - 20);
            okButton.Click += OkButton_Click;
            this.Controls.Add(okButton);

            // Cancel Button
            Button cancelButton = new Button
            {
                Text = "Cancel",
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 35),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.Location = new Point(okButton.Left - cancelButton.Width - 10, okButton.Top);
            cancelButton.Click += CancelButton_Click;
            this.Controls.Add(cancelButton);

            // Initialize action to cancel
            Action = MsgBoxAction.Cancel;

            // Resize event to reposition buttons
            this.Resize += ModernUI_MsgBox_Resize;
        }

        private void ModernUI_MsgBox_Resize(object sender, EventArgs e)
        {
            // Reposition the buttons when the UserControl is resized
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    if (button.Text == "OK")
                    {
                        button.Location = new Point(this.Width - button.Width - 20, this.Height - button.Height - 20);
                    }
                    else if (button.Text == "Cancel")
                    {
                        button.Location = new Point(this.Width - button.Width * 2 - 30, this.Height - button.Height - 20);
                    }
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Action = MsgBoxAction.Ok;
            this.ParentForm.DialogResult = DialogResult.OK;
            this.ParentForm.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Action = MsgBoxAction.Cancel;
            this.ParentForm.DialogResult = DialogResult.Cancel;
            this.ParentForm.Close();
        }

        public void SetMessage(string message)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label)
                {
                    label.Text = message;
                }
            }
        }

        public static MsgBoxAction Show(string message, string title = "Message")
        {
            Form form = new Form
            {
                Text = title,
                Size = new Size(400, 200),
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.White,
                ShowInTaskbar = false
            };

            modernUI_MsgBox msgBox = new modernUI_MsgBox();
            msgBox.SetMessage(message);
            form.Controls.Add(msgBox);

            form.ShowDialog();

            return msgBox.Action;
        }
    }
}
