using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Aont
{
    public partial class SettingControl : UserControl
    {
        public SettingControl()
        {
            InitializeComponent();

        }


        int _Space = 30;
        int _MinimumTextBoxSize = 30;

        public int Space
        {
            get { return this._Space; }
            set
            {
                this._Space = value;
                this.ValueTextbox.Left = (this.TitleLabel.Width / _Space + 1) * _Space;
            }
        }


        string _Title;
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this._Title = value;
                this.TitleLabel.Text = value;
                this.ValueTextbox.Left = (this.TitleLabel.Width / _Space + 1) * _Space;
            }
        }

        public string Value
        {
            get { return this.ValueTextbox.Text; }
            set { this.ValueTextbox.Text = value; }
        }

        public event EventHandler OnKeyEnter = delegate(object @object, EventArgs e) { };
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    this.OnKeyEnter(this, null);
                    break;
                default:
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SizeSet();
        }

        void SizeSet()
        {
            var Left = (this.TitleLabel.Width / _Space + 1) * _Space;
            var Width = this.Width;
            if (Width > Left + _MinimumTextBoxSize)
            {
                this.ValueTextbox.Top = 0;
                this.ValueTextbox.Left = Left;
                this.ValueTextbox.Width = Width - Left;
            }
            else
            {
                this.ValueTextbox.Left = 0;
                this.ValueTextbox.Top = this.TitleLabel.Height + 6;
                this.ValueTextbox.Width = Width;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SizeSet();
            base.OnPaint(e);
        }
    }
}
