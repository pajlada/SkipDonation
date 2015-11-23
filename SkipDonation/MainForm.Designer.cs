namespace SkipDonation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_skip_donation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hotkey = new System.Windows.Forms.Label();
            this.cb_hotkey_enabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_skip_donation
            // 
            this.btn_skip_donation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_skip_donation.Location = new System.Drawing.Point(12, 32);
            this.btn_skip_donation.Name = "btn_skip_donation";
            this.btn_skip_donation.Size = new System.Drawing.Size(268, 229);
            this.btn_skip_donation.TabIndex = 0;
            this.btn_skip_donation.Text = "Skip Donation";
            this.btn_skip_donation.UseVisualStyleBackColor = true;
            this.btn_skip_donation.Click += new System.EventHandler(this.btn_skip_donation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current hotkey:";
            // 
            // lbl_hotkey
            // 
            this.lbl_hotkey.AutoSize = true;
            this.lbl_hotkey.Location = new System.Drawing.Point(130, 14);
            this.lbl_hotkey.Name = "lbl_hotkey";
            this.lbl_hotkey.Size = new System.Drawing.Size(25, 13);
            this.lbl_hotkey.TabIndex = 3;
            this.lbl_hotkey.Text = "???";
            // 
            // cb_hotkey_enabled
            // 
            this.cb_hotkey_enabled.AutoSize = true;
            this.cb_hotkey_enabled.Checked = true;
            this.cb_hotkey_enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_hotkey_enabled.Location = new System.Drawing.Point(215, 12);
            this.cb_hotkey_enabled.Name = "cb_hotkey_enabled";
            this.cb_hotkey_enabled.Size = new System.Drawing.Size(65, 17);
            this.cb_hotkey_enabled.TabIndex = 4;
            this.cb_hotkey_enabled.Text = "Enabled";
            this.cb_hotkey_enabled.UseVisualStyleBackColor = true;
            this.cb_hotkey_enabled.CheckedChanged += new System.EventHandler(this.cb_hotkey_enabled_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.cb_hotkey_enabled);
            this.Controls.Add(this.lbl_hotkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_skip_donation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "StreamTip TTS Skipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_skip_donation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hotkey;
        private System.Windows.Forms.CheckBox cb_hotkey_enabled;
    }
}

