namespace AsteroidDodger
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            GameLoop = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // GameLoop
            // 
            GameLoop.Tick += GameLoop_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 578);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyUp += Form1_KeyUp;
            PreviewKeyDown += Form1_PreviewKeyDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
    }
}
