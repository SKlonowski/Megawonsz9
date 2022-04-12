
namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.IMG = new System.Windows.Forms.Label();
            this.Screenshot_Button = new System.Windows.Forms.PictureBox();
            this.colorBox = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.gifBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHighScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CzasGry = new System.Windows.Forms.Label();
            this.Czas_Textlabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeCounter = new System.Windows.Forms.Timer(this.components);
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screenshot_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(957, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 923);
            this.panel1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.IMG);
            this.panel7.Controls.Add(this.Screenshot_Button);
            this.panel7.Controls.Add(this.colorBox);
            this.panel7.Location = new System.Drawing.Point(5, 679);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(233, 69);
            this.panel7.TabIndex = 5;
            // 
            // IMG
            // 
            this.IMG.AutoSize = true;
            this.IMG.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMG.Location = new System.Drawing.Point(78, 19);
            this.IMG.Name = "IMG";
            this.IMG.Size = new System.Drawing.Size(74, 37);
            this.IMG.TabIndex = 2;
            this.IMG.Text = "IMG";
            // 
            // Screenshot_Button
            // 
            this.Screenshot_Button.Image = global::Snake.Properties.Resources.download_button;
            this.Screenshot_Button.Location = new System.Drawing.Point(158, 5);
            this.Screenshot_Button.Name = "Screenshot_Button";
            this.Screenshot_Button.Size = new System.Drawing.Size(70, 60);
            this.Screenshot_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Screenshot_Button.TabIndex = 1;
            this.Screenshot_Button.TabStop = false;
            this.Screenshot_Button.Click += new System.EventHandler(this.Screenshot_Button_Click);
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(3, 5);
            this.colorBox.Margin = new System.Windows.Forms.Padding(4);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(70, 60);
            this.colorBox.TabIndex = 0;
            this.colorBox.TabStop = false;
            this.colorBox.Paint += new System.Windows.Forms.PaintEventHandler(this.colorBox_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.exitButton);
            this.panel6.Controls.Add(this.infoButton);
            this.panel6.Location = new System.Drawing.Point(4, 752);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 164);
            this.panel6.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(4, 85);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(227, 74);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Koniec gry";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoButton.Location = new System.Drawing.Point(4, 4);
            this.infoButton.Margin = new System.Windows.Forms.Padding(4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(227, 74);
            this.infoButton.TabIndex = 7;
            this.infoButton.Text = "Informacje";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.gifBox);
            this.panel5.Location = new System.Drawing.Point(4, 512);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(235, 164);
            this.panel5.TabIndex = 5;
            // 
            // gifBox
            // 
            this.gifBox.Location = new System.Drawing.Point(4, 4);
            this.gifBox.Margin = new System.Windows.Forms.Padding(4);
            this.gifBox.Name = "gifBox";
            this.gifBox.Size = new System.Drawing.Size(225, 156);
            this.gifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifBox.TabIndex = 0;
            this.gifBox.TabStop = false;
            this.gifBox.Click += new System.EventHandler(this.gifBox_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtHighScore);
            this.panel4.Controls.Add(this.txtScore);
            this.panel4.Location = new System.Drawing.Point(5, 341);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(235, 164);
            this.panel4.TabIndex = 4;
            // 
            // txtHighScore
            // 
            this.txtHighScore.AutoSize = true;
            this.txtHighScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHighScore.Location = new System.Drawing.Point(4, 111);
            this.txtHighScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtHighScore.Name = "txtHighScore";
            this.txtHighScore.Size = new System.Drawing.Size(134, 26);
            this.txtHighScore.TabIndex = 1;
            this.txtHighScore.Text = "Top wynik:";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(4, 27);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(105, 26);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Wynik: 0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CzasGry);
            this.panel3.Controls.Add(this.Czas_Textlabel);
            this.panel3.Location = new System.Drawing.Point(4, 170);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 164);
            this.panel3.TabIndex = 3;
            // 
            // CzasGry
            // 
            this.CzasGry.AutoSize = true;
            this.CzasGry.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CzasGry.Location = new System.Drawing.Point(69, 105);
            this.CzasGry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CzasGry.Name = "CzasGry";
            this.CzasGry.Size = new System.Drawing.Size(87, 43);
            this.CzasGry.TabIndex = 1;
            this.CzasGry.Text = "--:--";
            // 
            // Czas_Textlabel
            // 
            this.Czas_Textlabel.AutoSize = true;
            this.Czas_Textlabel.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Czas_Textlabel.Location = new System.Drawing.Point(56, 16);
            this.Czas_Textlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Czas_Textlabel.Name = "Czas_Textlabel";
            this.Czas_Textlabel.Size = new System.Drawing.Size(111, 43);
            this.Czas_Textlabel.TabIndex = 0;
            this.Czas_Textlabel.Text = "Czas:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 164);
            this.panel2.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(4, 85);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(227, 74);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz wynik";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(4, 4);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(227, 74);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Nowa gra";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // TimeCounter
            // 
            this.TimeCounter.Tick += new System.EventHandler(this.TimeCounter_Tick);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Silver;
            this.picCanvas.Location = new System.Drawing.Point(16, 15);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(933, 923);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1207, 958);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picCanvas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MEGAWONSZ9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Screenshot_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gifBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label CzasGry;
        private System.Windows.Forms.Label Czas_Textlabel;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer TimeCounter;
        private System.Windows.Forms.PictureBox gifBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox colorBox;
        private System.Windows.Forms.PictureBox Screenshot_Button;
        private System.Windows.Forms.Label IMG;
    }
}

