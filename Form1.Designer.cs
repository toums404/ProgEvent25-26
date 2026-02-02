namespace ProgEvent25_26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Pb1 = new PictureBox();
            Pb2 = new PictureBox();
            bPermuter = new Button();
            Fenetre2 = new Button();
            ((System.ComponentModel.ISupportInitialize)Pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb2).BeginInit();
            SuspendLayout();
            // 
            // Pb1
            // 
            Pb1.Image = (Image)resources.GetObject("Pb1.Image");
            Pb1.Location = new Point(511, 64);
            Pb1.Name = "Pb1";
            Pb1.Size = new Size(400, 300);
            Pb1.SizeMode = PictureBoxSizeMode.Zoom;
            Pb1.TabIndex = 0;
            Pb1.TabStop = false;
            // 
            // Pb2
            // 
            Pb2.Image = (Image)resources.GetObject("Pb2.Image");
            Pb2.Location = new Point(55, 64);
            Pb2.Name = "Pb2";
            Pb2.Size = new Size(400, 300);
            Pb2.SizeMode = PictureBoxSizeMode.Zoom;
            Pb2.TabIndex = 1;
            Pb2.TabStop = false;
            // 
            // bPermuter
            // 
            bPermuter.Location = new Point(154, 396);
            bPermuter.Name = "bPermuter";
            bPermuter.Size = new Size(160, 147);
            bPermuter.TabIndex = 2;
            bPermuter.Text = "Permuter";
            bPermuter.UseVisualStyleBackColor = true;
            bPermuter.Click += bPermuter_Click;
            // 
            // Fenetre2
            // 
            Fenetre2.Location = new Point(565, 428);
            Fenetre2.Name = "Fenetre2";
            Fenetre2.Size = new Size(305, 83);
            Fenetre2.TabIndex = 3;
            Fenetre2.Text = "Aller a la deuxieme fenêtre";
            Fenetre2.UseVisualStyleBackColor = true;
            Fenetre2.Click += Fenetre2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 599);
            Controls.Add(Fenetre2);
            Controls.Add(bPermuter);
            Controls.Add(Pb2);
            Controls.Add(Pb1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Pb1;
        private PictureBox Pb2;
        private Button bPermuter;
        private Button Fenetre2;
    }
}
