namespace Simple_Fake_Identity_Generator
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelRespNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelRespDNI = new System.Windows.Forms.Label();
            this.LabelRespNum = new System.Windows.Forms.Label();
            this.LabelRespGen = new System.Windows.Forms.Label();
            this.LabelRespEdad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LabelRespPais = new System.Windows.Forms.Label();
            this.BtnCopy1 = new System.Windows.Forms.Button();
            this.BtnCopy2 = new System.Windows.Forms.Button();
            this.BtnCopy3 = new System.Windows.Forms.Button();
            this.BtnCopy4 = new System.Windows.Forms.Button();
            this.BtnCopy5 = new System.Windows.Forms.Button();
            this.BtnCopy6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Completo:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.helpToolStripMenuItem.Text = "Inicio";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.helpToolStripMenuItem1.Text = "Ayuda";
            // 
            // LabelRespNombre
            // 
            this.LabelRespNombre.AutoSize = true;
            this.LabelRespNombre.Location = new System.Drawing.Point(215, 173);
            this.LabelRespNombre.Name = "LabelRespNombre";
            this.LabelRespNombre.Size = new System.Drawing.Size(0, 20);
            this.LabelRespNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Género:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(70, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edad:";
            // 
            // LabelRespDNI
            // 
            this.LabelRespDNI.AutoSize = true;
            this.LabelRespDNI.Location = new System.Drawing.Point(215, 202);
            this.LabelRespDNI.Name = "LabelRespDNI";
            this.LabelRespDNI.Size = new System.Drawing.Size(0, 20);
            this.LabelRespDNI.TabIndex = 9;
            // 
            // LabelRespNum
            // 
            this.LabelRespNum.AutoSize = true;
            this.LabelRespNum.Location = new System.Drawing.Point(215, 232);
            this.LabelRespNum.Name = "LabelRespNum";
            this.LabelRespNum.Size = new System.Drawing.Size(0, 20);
            this.LabelRespNum.TabIndex = 10;
            // 
            // LabelRespGen
            // 
            this.LabelRespGen.AutoSize = true;
            this.LabelRespGen.Location = new System.Drawing.Point(215, 262);
            this.LabelRespGen.Name = "LabelRespGen";
            this.LabelRespGen.Size = new System.Drawing.Size(0, 20);
            this.LabelRespGen.TabIndex = 11;
            // 
            // LabelRespEdad
            // 
            this.LabelRespEdad.AutoSize = true;
            this.LabelRespEdad.Location = new System.Drawing.Point(215, 291);
            this.LabelRespEdad.Name = "LabelRespEdad";
            this.LabelRespEdad.Size = new System.Drawing.Size(0, 20);
            this.LabelRespEdad.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aleatorio",
            "Hombre",
            "Mujer"});
            this.comboBox1.Location = new System.Drawing.Point(70, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Género:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Aleatorio",
            "Argentina",
            "Chile",
            "Ecuador",
            "México",
            "Perú"});
            this.comboBox2.Location = new System.Drawing.Point(300, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(183, 28);
            this.comboBox2.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(300, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(592, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "País:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(70, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "País:";
            // 
            // LabelRespPais
            // 
            this.LabelRespPais.AutoSize = true;
            this.LabelRespPais.Location = new System.Drawing.Point(215, 320);
            this.LabelRespPais.Name = "LabelRespPais";
            this.LabelRespPais.Size = new System.Drawing.Size(36, 20);
            this.LabelRespPais.TabIndex = 20;
            this.LabelRespPais.Text = "pais";
            // 
            // BtnCopy1
            // 
            this.BtnCopy1.Location = new System.Drawing.Point(510, 169);
            this.BtnCopy1.Name = "BtnCopy1";
            this.BtnCopy1.Size = new System.Drawing.Size(31, 28);
            this.BtnCopy1.TabIndex = 21;
            this.BtnCopy1.Text = "C";
            this.BtnCopy1.UseVisualStyleBackColor = true;
            this.BtnCopy1.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // BtnCopy2
            // 
            this.BtnCopy2.Location = new System.Drawing.Point(510, 202);
            this.BtnCopy2.Name = "BtnCopy2";
            this.BtnCopy2.Size = new System.Drawing.Size(31, 28);
            this.BtnCopy2.TabIndex = 22;
            this.BtnCopy2.Text = "C";
            this.BtnCopy2.UseVisualStyleBackColor = true;
            this.BtnCopy2.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // BtnCopy3
            // 
            this.BtnCopy3.Location = new System.Drawing.Point(510, 232);
            this.BtnCopy3.Name = "BtnCopy3";
            this.BtnCopy3.Size = new System.Drawing.Size(31, 28);
            this.BtnCopy3.TabIndex = 23;
            this.BtnCopy3.Text = "C";
            this.BtnCopy3.UseVisualStyleBackColor = true;
            this.BtnCopy3.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // BtnCopy4
            // 
            this.BtnCopy4.Location = new System.Drawing.Point(510, 262);
            this.BtnCopy4.Name = "BtnCopy4";
            this.BtnCopy4.Size = new System.Drawing.Size(31, 28);
            this.BtnCopy4.TabIndex = 24;
            this.BtnCopy4.Text = "C";
            this.BtnCopy4.UseVisualStyleBackColor = true;
            this.BtnCopy4.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // BtnCopy5
            // 
            this.BtnCopy5.Location = new System.Drawing.Point(510, 291);
            this.BtnCopy5.Name = "BtnCopy5";
            this.BtnCopy5.Size = new System.Drawing.Size(31, 28);
            this.BtnCopy5.TabIndex = 25;
            this.BtnCopy5.Text = "C";
            this.BtnCopy5.UseVisualStyleBackColor = true;
            this.BtnCopy5.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // BtnCopy6
            // 
            this.BtnCopy6.Location = new System.Drawing.Point(510, 320);
            this.BtnCopy6.Name = "BtnCopy6";
            this.BtnCopy6.Size = new System.Drawing.Size(31, 28);
            this.BtnCopy6.TabIndex = 26;
            this.BtnCopy6.Text = "C";
            this.BtnCopy6.UseVisualStyleBackColor = true;
            this.BtnCopy6.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "pais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(70, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha Nacimiento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnCopy6);
            this.Controls.Add(this.BtnCopy5);
            this.Controls.Add(this.BtnCopy4);
            this.Controls.Add(this.BtnCopy3);
            this.Controls.Add(this.BtnCopy2);
            this.Controls.Add(this.BtnCopy1);
            this.Controls.Add(this.LabelRespPais);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelRespEdad);
            this.Controls.Add(this.LabelRespGen);
            this.Controls.Add(this.LabelRespNum);
            this.Controls.Add(this.LabelRespDNI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelRespNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private Label LabelRespNombre;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label LabelRespDNI;
        private Label LabelRespNum;
        private Label LabelRespGen;
        private Label LabelRespEdad;
        private ComboBox comboBox1;
        private Label label11;
        private ComboBox comboBox2;
        private Label label12;
        private PictureBox pictureBox1;
        private Label label13;
        private Label label14;
        private Label LabelRespPais;
        private Button BtnCopy1;
        private Button BtnCopy2;
        private Button BtnCopy3;
        private Button BtnCopy4;
        private Button BtnCopy5;
        private Button BtnCopy6;
        private Label label3;
        private Label label7;
    }
}