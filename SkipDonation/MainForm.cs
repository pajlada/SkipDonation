using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkipDonation;

namespace SkipDonation
{
    public partial class MainForm : Form
    {
        KeyboardHook hook = new KeyboardHook();
        DateTime last_run = DateTime.UtcNow.AddSeconds(-10);

        public MainForm()
        {
            InitializeComponent();

            this.hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);

            this.enable_hotkey();
        }

        void enable_hotkey()
        {
            this.set_hotkey("Ctrl+X");
            // lbl_hotkey.ForeColor = SystemColors.ControlText;
        }

        void disable_hotkey()
        {
            this.hook.Dispose();
            lbl_hotkey.Text = "Disabled";
        }

        bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        public void set_hotkey(string hotkey_string)
        {
            var cvt = new KeysConverter();
            var key = (Keys)cvt.ConvertFrom(hotkey_string);

            ModifierKeys mk = SkipDonation.ModifierKeys.None;

            if (key.HasFlag(Keys.Control))
            {
                mk |= SkipDonation.ModifierKeys.Control;
                key = key & (~Keys.Control);
            }

            if (key.HasFlag(Keys.Alt))
            {
                mk |= SkipDonation.ModifierKeys.Alt;
                key = key & (~Keys.Alt);
            }

            if (key.HasFlag(Keys.Shift))
            {
                mk |= SkipDonation.ModifierKeys.Shift;
                key = key & (~Keys.Shift);
            }

            hook.RegisterHotKey(mk, key);
            lbl_hotkey.Text = hotkey_string;
        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            var diff = (DateTime.UtcNow - this.last_run).TotalSeconds;
            if (diff > 1.2)
            {
                btn_skip_donation_Click(null, null);
                this.last_run = DateTime.UtcNow;
            }
        }

        private void btn_skip_donation_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("Node2Speech"))
            {
                process.Kill();
            }
        }

        private void cb_hotkey_enabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked) {
                this.enable_hotkey();
            } else {
                this.disable_hotkey();
            }
        }
    }
}
