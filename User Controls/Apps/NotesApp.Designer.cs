
namespace IphoneSimulator.User_Controls.Apps
{
    partial class NotesApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.TittleBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.NoteBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 10;
            this.label2.Tag = "";
            this.label2.Text = "Notes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TittleBox
            // 
            this.TittleBox.Animated = true;
            this.TittleBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.TittleBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TittleBox.DefaultText = "";
            this.TittleBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TittleBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TittleBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TittleBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TittleBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.TittleBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TittleBox.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TittleBox.Location = new System.Drawing.Point(0, 36);
            this.TittleBox.Name = "TittleBox";
            this.TittleBox.PasswordChar = '\0';
            this.TittleBox.PlaceholderText = "Tittle...";
            this.TittleBox.SelectedText = "";
            this.TittleBox.Size = new System.Drawing.Size(200, 37);
            this.TittleBox.TabIndex = 11;
            this.TittleBox.TextChanged += new System.EventHandler(this.TittleBox_TextChanged);
            // 
            // NoteBox
            // 
            this.NoteBox.Animated = true;
            this.NoteBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.NoteBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NoteBox.DefaultText = "";
            this.NoteBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NoteBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NoteBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoteBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoteBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this.NoteBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoteBox.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Bold);
            this.NoteBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoteBox.Location = new System.Drawing.Point(0, 79);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.PasswordChar = '\0';
            this.NoteBox.PlaceholderText = "Note Text...";
            this.NoteBox.SelectedText = "";
            this.NoteBox.Size = new System.Drawing.Size(200, 293);
            this.NoteBox.TabIndex = 12;
            this.NoteBox.TextChanged += new System.EventHandler(this.NoteBox_TextChanged);
            // 
            // NotesApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.TittleBox);
            this.Controls.Add(this.label2);
            this.Name = "NotesApp";
            this.Size = new System.Drawing.Size(200, 372);
            this.Load += new System.EventHandler(this.NotesApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TittleBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox NoteBox;
    }
}
