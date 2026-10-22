
namespace AdCover
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LeftDockButton = new DataJuggler.Win.Controls.Button();
            RightButton = new DataJuggler.Win.Controls.Button();
            SuspendLayout();
            // 
            // LeftDockButton
            // 
            LeftDockButton.BackColor = System.Drawing.Color.Transparent;
            LeftDockButton.ButtonText = "Left";
            LeftDockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LeftDockButton.ForeColor = System.Drawing.Color.LemonChiffon;
            LeftDockButton.Location = new System.Drawing.Point(12, 12);
            LeftDockButton.Name = "LeftDockButton";
            LeftDockButton.Size = new System.Drawing.Size(120, 44);
            LeftDockButton.TabIndex = 0;
            LeftDockButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            LeftDockButton.UseMnemonic = true;
            LeftDockButton.Click += LeftDockButton_Click;
            // 
            // RightButton
            // 
            RightButton.BackColor = System.Drawing.Color.Transparent;
            RightButton.ButtonText = "Right";
            RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RightButton.ForeColor = System.Drawing.Color.LemonChiffon;
            RightButton.Location = new System.Drawing.Point(12, 62);
            RightButton.Name = "RightButton";
            RightButton.Size = new System.Drawing.Size(120, 44);
            RightButton.TabIndex = 1;
            RightButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            RightButton.UseMnemonic = true;
            RightButton.Click += RightButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(RightButton);
            Controls.Add(LeftDockButton);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Ad Cover";
            TopMost = true;
            Load += MainForm_Load;
            ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.Button LeftDockButton;
        private DataJuggler.Win.Controls.Button RightButton;
    }
}

