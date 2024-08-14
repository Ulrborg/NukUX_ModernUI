using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NukUX_ModernUI
{
    public partial class modernUI_Button : UserControl
    {
        private Color _defaultBackColor = Color.MediumSlateBlue;
        private Color _mouseEnterColor = Color.SlateBlue;
        private Color _mouseDownColor = Color.DarkSlateBlue;
        private Color _mouseLeaveColor = Color.MediumSlateBlue;
        private Color _mouseUpColor = Color.SlateBlue;

        public modernUI_Button()
        {
            this.Size = new Size(150, 40);
            this.BackColor = _defaultBackColor;
            this.ForeColor = Color.White;
            this.DoubleBuffered = true;
            this.Text = "Click me !"; // Default text

            this.Paint += ModernUI_Button_Paint;
            this.MouseEnter += ModernUI_Button_MouseEnter;
            this.MouseLeave += ModernUI_Button_MouseLeave;
            this.MouseDown += ModernUI_Button_MouseDown;
            this.MouseUp += ModernUI_Button_MouseUp;
        }

        private void ModernUI_Button_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10; // Set border-radius to 5px
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90);
            path.AddArc(new Rectangle(this.Width - borderRadius, 0, borderRadius, borderRadius), -90, 90);
            path.AddArc(new Rectangle(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - borderRadius, borderRadius, borderRadius), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            // Draw background
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
            }

            // Draw text centered
            TextRenderer.DrawText(e.Graphics, this.ButtonText, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void ModernUI_Button_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = MouseEnterColor; // Change color on hover
        }

        private void ModernUI_Button_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = MouseLeaveColor; // Revert color when mouse leaves
        }

        private void ModernUI_Button_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = MouseDownColor; // Change color on mouse down
        }

        private void ModernUI_Button_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = MouseUpColor; // Revert color on mouse up
        }

        // Property to get or set the button text
        [Category("Appearance")]
        [Description("Sets the text displayed on the button.")]
        public string ButtonText
        {
            get { return this.Text; }
            set { this.Text = value; this.Invalidate(); } // Redraw to update text
        }

        // Properties to change the colors for different states
        [Category("Appearance")]
        [Description("Sets the background color when the mouse enters the button area.")]
        public Color MouseEnterColor
        {
            get { return _mouseEnterColor; }
            set { _mouseEnterColor = value; }
        }

        [Category("Appearance")]
        [Description("Sets the background color when the mouse leaves the button area.")]
        public Color MouseLeaveColor
        {
            get { return _mouseLeaveColor; }
            set { _mouseLeaveColor = value; }
        }

        [Category("Appearance")]
        [Description("Sets the background color when the mouse is pressed down on the button.")]
        public Color MouseDownColor
        {
            get { return _mouseDownColor; }
            set { _mouseDownColor = value; }
        }

        [Category("Appearance")]
        [Description("Sets the background color when the mouse is released on the button.")]
        public Color MouseUpColor
        {
            get { return _mouseUpColor; }
            set { _mouseUpColor = value; }
        }
    }
}
