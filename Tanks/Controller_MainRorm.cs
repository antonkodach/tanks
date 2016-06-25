using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Tanks
{
    /// <summary>
    /// W tym klasie opisany control naszą formą
    /// </summary>
    public partial class Controller_MainForm : Form
    {
        View view;
        Model model;
        bool isSound;
        SoundPlayer sp;

        Thread modelPlay; // Stworzylismy nowy potok gry

        public Controller_MainForm() : this(260) { } //Безпараметровий конструктор
        public Controller_MainForm(int sizeField) : this(sizeField, 5) { }  // з 1 параметром
        public Controller_MainForm(int sizeField, int amountTanks) : this(sizeField, amountTanks, 5) { } // з двома параметрами
        public Controller_MainForm(int sizeField, int amountTanks, int amountApples) : this(sizeField, amountTanks, amountApples, 40) { } // з трьома параметрами
        public Controller_MainForm(int sizeField,int amountTanks, int amountApples, int speedGame) // кінцевий конструктор з усіма параметрами
        {
            InitializeComponent();
            model = new Model(sizeField, amountTanks, amountApples, speedGame); //Створили обєкт модельки, вона і буде рухати наші сучності
            model.changeStreep += new STREEP(ChangerStatusStripLbl);
            view = new View(model); // Створили об'єкт
            this.Controls.Add(view); // Помістили на форму створений об'єкт

            isSound = true;
            sp = new SoundPlayer(Properties.Resources.TankMov);
        }
         /// <summary>
         /// Ta metoda włącza i wyłacza dżwieńk, i pokażuje status gry 
         /// </summary>
        void ChangerStatusStripLbl() // zminiuje ststus gry z nyzu
        {
            GameStatus_lbl_ststrp.Text = model.gameStatus.ToString();
            if (isSound)
            {
                if (model.gameStatus == GameStatus.playing)
                    sp.PlayLooping();
                else
                    sp.Stop();
            }
        }

        private void StartPause_btn_Click(object sender, EventArgs e) //Naciskanie na knopku// 
        {
            if (model.gameStatus == GameStatus.playing) // Kiedy gramy w gru przycisk nazywa się Stop, Kiedy gra stoi - przycisk nazywa się Play
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.stoping;
                StartStop_pcbx.Image = Properties.Resources.PlayButton;
                ChangerStatusStripLbl();
            }
            else 
            {
                StartStop_pcbx.Focus(); //Ustawiamy PictureBox w Focus i mozemy kierowac tankiem
                model.gameStatus = GameStatus.playing;
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                StartStop_pcbx.Image = Properties.Resources.PauseButton; // Naciskamy przycisk Stop
                ChangerStatusStripLbl();
                view.Invalidate(); //Pererysowuje nasz UserControl
            }
        }

        private void Controller_MainForm_FormClosing(object sender, FormClosingEventArgs e) //Zamykanie gry i wszystkich potoków
        {
            if (modelPlay != null)

                model.gameStatus = GameStatus.stoping;
                //modelPlay.Abort();

          DialogResult dr = MessageBox.Show("Do you want to exit from Games? // Ви дійсно хочете залишить гру?", "Танки", MessageBoxButtons.YesNoCancel);
          if (dr == DialogResult.Yes)
              e.Cancel = false;
          else
              e.Cancel = true;
        }


        private void StartStop_pcbx_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData.ToString())
            {

                case "A":
                    {
                        model.Packman.NextDirect_x = -1;
                        model.Packman.NextDirect_y = 0;
                    }
                    break;

                case "D":
                    {
                        model.Packman.NextDirect_x = 1;
                        model.Packman.NextDirect_y = 0;
                    }
                    break;
                case "W":
                    {
                        model.Packman.NextDirect_x = 0;
                        model.Packman.NextDirect_y = -1;
                    }
                    break;

                case "S":
                    {
                        model.Packman.NextDirect_x = 0;
                        model.Packman.NextDirect_y = 1;
                    }
                    break;
                case "L":
                    {
                        model.Projectile.Direct_x = model.Packman.Direct_x;
                        model.Projectile.Direct_y = model.Packman.Direct_y;

                        if (model.Packman.Direct_y == -1)
                        {
                            model.Projectile.X = model.Packman.X + 10;
                            model.Projectile.Y = model.Packman.Y;
                        }
                        if (model.Packman.Direct_y == 1)
                        {
                            model.Projectile.X = model.Packman.X + 10;
                            model.Projectile.Y = model.Packman.Y + 20;
                        }
                        if (model.Packman.Direct_x == -1)
                        {
                            model.Projectile.Y = model.Packman.Y + 10;
                            model.Projectile.X = model.Packman.X;
                        }
                        if (model.Packman.Direct_y == 1)
                        {
                            model.Projectile.X = model.Packman.X + 10;
                            model.Projectile.Y = model.Packman.Y + 10;
                        }

                    }
                    break;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Klas ktory zapuska gru i moze kontrolowac jakis funkcji
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.NewGame();
            StartStop_pcbx.Image = Properties.Resources.PlayButton; //Zminiuje knopku Play/Stop
            view.Refresh(); //Widnowluje pole pislia natysku - nowa gra // pererysowuje wse pole
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gra Tanks(wersji 1.0), Zrobiona przez Anton Kodach w53402, Grupa 4IID,///////// Dla kierowania czowgiem wykorzystywać litery: A,S,D,W,L","Tanks");
        }

        private void SoundToolStripMenuItem_Click(object sender, EventArgs e) //wlączzanie i wywacvznie dziwieęku
        {
            isSound = !isSound;
        }
    }
}
