
namespace SimpleChiaPlotter
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuyMeACoffee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(91, 132);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(694, 145);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(157, 294);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(99, 29);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "GitHub: ";
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.Location = new System.Drawing.Point(257, 292);
            this.linkLabelAuthor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(433, 29);
            this.linkLabelAuthor.TabIndex = 2;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "https://github.com/vanthoi/Achi-Plot-Gui";
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuthor_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 65);
            this.label1.TabIndex = 3;
            this.label1.Text = "Achi Plotter GUI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Does this app help you out?\r\n";
            // 
            // btnBuyMeACoffee
            // 
            this.btnBuyMeACoffee.AutoSize = true;
            this.btnBuyMeACoffee.BackgroundImage = global::AchiPlotter.Properties.Resources.BuyMeACoffee;
            this.btnBuyMeACoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuyMeACoffee.Location = new System.Drawing.Point(168, 381);
            this.btnBuyMeACoffee.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnBuyMeACoffee.Name = "btnBuyMeACoffee";
            this.btnBuyMeACoffee.Size = new System.Drawing.Size(518, 149);
            this.btnBuyMeACoffee.TabIndex = 32;
            this.btnBuyMeACoffee.UseVisualStyleBackColor = true;
            this.btnBuyMeACoffee.Click += new System.EventHandler(this.btnBuyMeACoffee_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 547);
            this.Controls.Add(this.btnBuyMeACoffee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "FrmAbout";
            this.Text = "About Achi Plotter GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuyMeACoffee;
        private System.Windows.Forms.Label label2;
    }
}