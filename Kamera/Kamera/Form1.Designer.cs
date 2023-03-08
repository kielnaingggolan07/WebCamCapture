namespace Kamera
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
            comboBoxWebcamlist = new ComboBox();
            buttonstart = new Button();
            buttoncapture = new Button();
            buttonsaveimage = new Button();
            buttonexit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            prBox1 = new PictureBox();
            prBox2 = new PictureBox();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamlist
            // 
            comboBoxWebcamlist.BackColor = SystemColors.MenuHighlight;
            comboBoxWebcamlist.FormattingEnabled = true;
            comboBoxWebcamlist.Location = new Point(12, 82);
            comboBoxWebcamlist.Name = "comboBoxWebcamlist";
            comboBoxWebcamlist.Size = new Size(234, 33);
            comboBoxWebcamlist.TabIndex = 0;
            // 
            // buttonstart
            // 
            buttonstart.BackColor = SystemColors.MenuHighlight;
            buttonstart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonstart.Location = new Point(252, 82);
            buttonstart.Name = "buttonstart";
            buttonstart.Size = new Size(91, 33);
            buttonstart.TabIndex = 1;
            buttonstart.Text = "Start";
            buttonstart.UseVisualStyleBackColor = false;
            buttonstart.Click += buttonstart_Click;
            // 
            // buttoncapture
            // 
            buttoncapture.BackColor = SystemColors.MenuHighlight;
            buttoncapture.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttoncapture.Location = new Point(349, 82);
            buttoncapture.Name = "buttoncapture";
            buttoncapture.Size = new Size(91, 33);
            buttoncapture.TabIndex = 2;
            buttoncapture.Text = "Capture";
            buttoncapture.UseVisualStyleBackColor = false;
            buttoncapture.Click += button2_Click;
            // 
            // buttonsaveimage
            // 
            buttonsaveimage.BackColor = SystemColors.MenuHighlight;
            buttonsaveimage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsaveimage.Location = new Point(446, 82);
            buttonsaveimage.Name = "buttonsaveimage";
            buttonsaveimage.Size = new Size(135, 33);
            buttonsaveimage.TabIndex = 3;
            buttonsaveimage.Text = "Save Image";
            buttonsaveimage.UseVisualStyleBackColor = false;
            buttonsaveimage.Click += buttonsaveimage_Click;
            // 
            // buttonexit
            // 
            buttonexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonexit.Location = new Point(864, 82);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(70, 33);
            buttonexit.TabIndex = 4;
            buttonexit.Text = "Exit";
            buttonexit.UseVisualStyleBackColor = true;
            buttonexit.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(prBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(prBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 134);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(922, 452);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // prBox1
            // 
            prBox1.Dock = DockStyle.Fill;
            prBox1.Location = new Point(3, 3);
            prBox1.Name = "prBox1";
            prBox1.Size = new Size(455, 446);
            prBox1.SizeMode = PictureBoxSizeMode.Zoom;
            prBox1.TabIndex = 0;
            prBox1.TabStop = false;
            prBox1.Click += prBox1_Click;
            // 
            // prBox2
            // 
            prBox2.Dock = DockStyle.Fill;
            prBox2.Location = new Point(464, 3);
            prBox2.Name = "prBox2";
            prBox2.Size = new Size(455, 446);
            prBox2.SizeMode = PictureBoxSizeMode.Zoom;
            prBox2.TabIndex = 1;
            prBox2.TabStop = false;
            prBox2.Click += prBox2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GradientActiveCaption;
            textBox1.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(252, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(463, 40);
            textBox1.TabIndex = 6;
            textBox1.Text = "Aplikasi Web Camera Capture";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(957, 603);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonexit);
            Controls.Add(buttonsaveimage);
            Controls.Add(buttoncapture);
            Controls.Add(buttonstart);
            Controls.Add(comboBoxWebcamlist);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)prBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)prBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxWebcamlist;
        private Button buttonstart;
        private Button buttoncapture;
        private Button buttonsaveimage;
        private Button buttonexit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox prBox1;
        private PictureBox prBox2;
        private TextBox textBox1;
    }
}