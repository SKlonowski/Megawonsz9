using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Snake
{
    public partial class Form1 : Form
    {


        private List<Shape> Snake = new List<Shape>();
        private List<Shape> food = new List<Shape>();

        private List<Brush> kolory = new List<Brush>();
        public Brush snakeColour = Brushes.DarkRed;
        public int ktory_kolor = 0;
        int nr_wersji = 2;
        int nr_rozgrywki = 0;
        //private Shape food = new Shape();

        int maxWidth;
        int maxHeight;

        int score;
        int owoc;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;


        Bitmap img1 = Properties.Resources.megawonsz9;
        Bitmap img2 = Properties.Resources.Wonsz_rzeczny;
        Bitmap img3 = Properties.Resources.Wonsz_rzeczny_tekst;


        public Form1()
        {
            InitializeComponent();
            new Settings();
            gifBox.Image = img1;

            Screenshot_Button.Enabled = false;
            saveButton.Enabled = false;
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            RestartGame();
            counter = 500;
            TimeCounter = new System.Windows.Forms.Timer();
            TimeCounter.Tick += new EventHandler(TimeCounter_Tick);
            TimeCounter.Interval = 1000; // 1 second

            TimeCounter.Start();
            CzasGry.Text = counter.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            SaveCSV();

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Gra typu Snejk.\nNapisana zgodnie z wolą MEGAWENSZA9\n                                            SK 24.03.2022", "Informacje",
                  System.Windows.Forms.MessageBoxButtons.OK,
                  System.Windows.Forms.MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int counter = 500;
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    for (int j = 0; j < food.Count; j++)
                    {
                        if (Snake[i].X == food[j].X && Snake[i].Y == food[j].Y)
                        {

                            ktory_kolor = j;
                            EatFood();
                        }
                    }
                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }


            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            //dla teczowego wonsza
            Random r = new Random();
            int rInt = r.Next(0, 4);

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = kolory[ktory_kolor];
                }

                canvas.FillRectangle(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }

            for (int j = 0; j < food.Count; j++)
            {
                canvas.FillEllipse(kolory[j], new Rectangle
                    (
                    food[j].X * Settings.Width,
                    food[j].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }
        }

        private void TimeCounter_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)

                TimeCounter.Stop();

            if (counter == 0)
                GameOver();
            CzasGry.Text = counter.ToString();
        }

        private void PlayAudio()
        {
            SoundPlayer snd = null;
            Stream str = Properties.Resources.Wonsz_żeczny_wav;
            snd = new SoundPlayer(str);
            snd.Play();
        }

        private void gifBox_Click(object sender, EventArgs e)
        {

            if (gifBox.Image == img1)
            {
                gifBox.Image = img2;
                SoundPlayer snd = null;
                Stream str = Properties.Resources.Wonsz_żeczny_wav;
                snd = new SoundPlayer(str);
                snd.Stop();

            }

            else if (gifBox.Image == img2)
            {
                gifBox.Image = img3;
                PlayAudio();
            }
            else
            {
                gifBox.Image = img1;
                SoundPlayer snd = null;
                Stream str = Properties.Resources.Wonsz_żeczny_wav;
                snd = new SoundPlayer(str);
                snd.Stop();

            }
        }



        private void colorBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            canvas.FillRectangle(snakeColour, new Rectangle
                    (
                    0,
                    0,
                    169,
                    49
                    ));

        }
        /*
        private void SaveCSV()
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "SNEJK";
            string filter = "CSV file (*.csv)|*.csv";
            saveFileDialog1.Filter = filter;
            const string header = "id,nr_wersji,nr_rozgrywki,ilosc_pk,ilosc_owc,kolizja,kary,podpowiedzi,timestamp,Pozostaly_czas";
            StreamWriter writer = null;



            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filter = saveFileDialog1.FileName;
                writer = new StreamWriter(filter);

                writer.WriteLine(header);
                writer.Close();
            }

        }
        */

        private void SaveCSV()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "SNEJK";
            string filter = "CSV file (*.csv)|*.csv";
            saveFileDialog1.Filter = filter;
            const string header = "id,nr_wersji,nr_rozgrywki,ilosc_pk,ilosc_owc,kolizja,kary,podpowiedzi,timestamp,Pozostaly_czas";
            StreamWriter writer = null;
            Random ran = new Random();
            int id = ran.Next(0, 10000);
            string[] colors = new string[]
            {
                id.ToString(),
                nr_wersji.ToString(),
                nr_rozgrywki.ToString(),
                score.ToString(),
                owoc.ToString(),

            };
            //foreach (string s in colors)
            //{
            //    Text += s + "<br />";
            //}
            string commaseparatedstring = String.Join(",", colors);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filter = saveFileDialog1.FileName;
                writer = new StreamWriter(filter);
                writer.WriteLine(header);
                writer.WriteLine(commaseparatedstring);
                writer.Close();
            }
            //return File(myExport.ExportToBytes(), "text/csv", "results.csv");
        }


        private void Screenshot_Button_Click(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "I scored: " + score + " and my Highscore is " + highScore;
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor = Color.Purple;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "SNEJK";

            dialog.Filter = "JPG File|*.jpg|JPEG File|*.jpeg|PNG File|*.png";
            dialog.ValidateNames = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
            else
                picCanvas.Controls.Remove(caption);

        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();

            //dodawanie kolorow
            kolory.Clear();
            kolory.Add(Brushes.DarkRed);
            kolory.Add(Brushes.ForestGreen);
            kolory.Add(Brushes.DarkBlue);
            kolory.Add(Brushes.Gold);

            startButton.Enabled = false;
            saveButton.Enabled = false;
            infoButton.Enabled = false;
            exitButton.Enabled = false;
            Screenshot_Button.Enabled = false;
            score = 0;
            owoc = 0;
            nr_rozgrywki = nr_rozgrywki + 1;
            txtScore.Text = "Wynik: " + score;

            Shape head = new Shape { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Shape body = new Shape();
                Snake.Add(body);
            }
            food.Clear();
            Shape food_start = new Shape { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
            food.Add(food_start);

            gameTimer.Start();



        }
        private void EatFood()
        {
            Random r = new Random();
            if (snakeColour == kolory[ktory_kolor])
                score += 2;
            else
                score += 1;
            if (owoc >= 5)
                ktory_kolor = r.Next(0, 4);
            else
                ktory_kolor = 0;
            owoc += 1;
            txtScore.Text = "Wynik: " + score;

            Shape body = new Shape
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(body);
            food.Clear();


            snakeColour = kolory[ktory_kolor];
            colorBox.Invalidate();


            for (int j = 0; j < 4; j++)
            {
                food.Add(new Shape { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) });
            }


        }

        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;
            saveButton.Enabled = true;
            infoButton.Enabled = true;
            exitButton.Enabled = true;
            Screenshot_Button.Enabled = true;
            TimeCounter.Stop();

            if (score > highScore)
            {
                highScore = score;

                txtHighScore.Text = "Top wynik: " + Environment.NewLine + highScore;
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
            SaveCSV();
        }

    }
}

