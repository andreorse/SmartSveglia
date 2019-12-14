namespace radio_sveglia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonHome1 = new System.Windows.Forms.Button();
            this.buttonHome2 = new System.Windows.Forms.Button();
            this.buttonHome3 = new System.Windows.Forms.Button();
            this.dataOggi = new System.Windows.Forms.DateTimePicker();
            this.numOraAtt = new System.Windows.Forms.NumericUpDown();
            this.numMinAtt = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFatto1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOraAtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAtt)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonFatto1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.numMinAtt);
            this.tabPage2.Controls.Add(this.numOraAtt);
            this.tabPage2.Controls.Add(this.dataOggi);
            this.tabPage2.Controls.Add(this.buttonHome1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Imposta ora e giorno";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttonHome2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Imposta sveglia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonHome3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(795, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Google Calendar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(149, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Imposta ora e giorno di oggi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(445, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Imposta sveglia";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(297, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 100);
            this.button3.TabIndex = 2;
            this.button3.Text = "Google Calendar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonHome1
            // 
            this.buttonHome1.AutoSize = true;
            this.buttonHome1.Location = new System.Drawing.Point(0, 401);
            this.buttonHome1.Name = "buttonHome1";
            this.buttonHome1.Size = new System.Drawing.Size(110, 23);
            this.buttonHome1.TabIndex = 0;
            this.buttonHome1.Text = "<-- Torna alla Home";
            this.buttonHome1.UseVisualStyleBackColor = true;
            this.buttonHome1.Click += new System.EventHandler(this.buttonHome1_Click);
            // 
            // buttonHome2
            // 
            this.buttonHome2.AutoSize = true;
            this.buttonHome2.Location = new System.Drawing.Point(0, 401);
            this.buttonHome2.Name = "buttonHome2";
            this.buttonHome2.Size = new System.Drawing.Size(110, 23);
            this.buttonHome2.TabIndex = 0;
            this.buttonHome2.Text = "<-- Torna alla Home";
            this.buttonHome2.UseVisualStyleBackColor = true;
            this.buttonHome2.Click += new System.EventHandler(this.buttonHome2_Click);
            // 
            // buttonHome3
            // 
            this.buttonHome3.AutoSize = true;
            this.buttonHome3.Location = new System.Drawing.Point(0, 401);
            this.buttonHome3.Name = "buttonHome3";
            this.buttonHome3.Size = new System.Drawing.Size(110, 23);
            this.buttonHome3.TabIndex = 0;
            this.buttonHome3.Text = "<-- Torna alla Home";
            this.buttonHome3.UseVisualStyleBackColor = true;
            this.buttonHome3.Click += new System.EventHandler(this.buttonHome3_Click);
            // 
            // dataOggi
            // 
            this.dataOggi.Location = new System.Drawing.Point(297, 224);
            this.dataOggi.Name = "dataOggi";
            this.dataOggi.Size = new System.Drawing.Size(200, 20);
            this.dataOggi.TabIndex = 1;
            // 
            // numOraAtt
            // 
            this.numOraAtt.Location = new System.Drawing.Point(253, 136);
            this.numOraAtt.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numOraAtt.Name = "numOraAtt";
            this.numOraAtt.Size = new System.Drawing.Size(100, 20);
            this.numOraAtt.TabIndex = 2;
            // 
            // numMinAtt
            // 
            this.numMinAtt.Location = new System.Drawing.Point(441, 136);
            this.numMinAtt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinAtt.Name = "numMinAtt";
            this.numMinAtt.Size = new System.Drawing.Size(100, 20);
            this.numMinAtt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "giorno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(138, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(518, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "IMPOSTA ORA E GIORNO ATTUALI";
            // 
            // buttonFatto1
            // 
            this.buttonFatto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFatto1.Location = new System.Drawing.Point(347, 302);
            this.buttonFatto1.Name = "buttonFatto1";
            this.buttonFatto1.Size = new System.Drawing.Size(100, 50);
            this.buttonFatto1.TabIndex = 8;
            this.buttonFatto1.Text = "FATTO";
            this.buttonFatto1.UseVisualStyleBackColor = true;
            this.buttonFatto1.Click += new System.EventHandler(this.buttonFatto1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(255, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "IMPOSTA SVEGLIA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOraAtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAtt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonHome1;
        private System.Windows.Forms.Button buttonHome2;
        private System.Windows.Forms.Button buttonHome3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMinAtt;
        private System.Windows.Forms.NumericUpDown numOraAtt;
        private System.Windows.Forms.DateTimePicker dataOggi;
        private System.Windows.Forms.Button buttonFatto1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

