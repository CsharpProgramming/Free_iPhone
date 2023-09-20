
namespace IphoneSimulator.User_Controls
{
    partial class AppOpened
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppOpened));
            this.HomeScreenBG = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelAppContainer = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreenBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeScreenBG
            // 
            this.HomeScreenBG.Image = ((System.Drawing.Image)(resources.GetObject("HomeScreenBG.Image")));
            this.HomeScreenBG.Location = new System.Drawing.Point(0, 0);
            this.HomeScreenBG.Name = "HomeScreenBG";
            this.HomeScreenBG.Size = new System.Drawing.Size(885, 494);
            this.HomeScreenBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeScreenBG.TabIndex = 10;
            this.HomeScreenBG.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(481, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(363, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Tag = "";
            this.label2.Text = "10:00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelAppContainer
            // 
            this.PanelAppContainer.Location = new System.Drawing.Point(342, 58);
            this.PanelAppContainer.Name = "PanelAppContainer";
            this.PanelAppContainer.Size = new System.Drawing.Size(200, 372);
            this.PanelAppContainer.TabIndex = 14;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // AppOpened
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PanelAppContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.HomeScreenBG);
            this.Name = "AppOpened";
            this.Size = new System.Drawing.Size(885, 494);
            this.Load += new System.EventHandler(this.AppOpened_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppOpened_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.HomeScreenBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomeScreenBG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelAppContainer;
        private System.Windows.Forms.Timer timer2;
    }
}
