using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Tanks
{ // Клас View в якому будуть виводитися зображення
    /// <summary>
    /// Klas, w którym wyłolujemy zdjęcia
    /// </summary>
    partial class View : UserControl
    {
        Model model;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model">Peredajemy do metody obiekt model</param>
        public View(Model model)
        {
            InitializeComponent();

            this.model = model;

            

        }
        /// <summary>
        /// Metoda odpowiada za wyłolanie grafiky w projekcie
        /// </summary>
        /// <param name="e"></param>
        void Draw(PaintEventArgs e) // відповідає за вивід графіки в ігрі
        {
            DarwWall(e);
            DrawFireTank(e);
            DrawApple(e);
            DrawTank(e);
            DrawPackman(e);
            DrawProjectile(e);

            if (model.gameStatus != GameStatus.playing) // Якщо грп не працює - то ми просто виходимо з методи
                return;
            
            Thread.Sleep(model.speedGame);
            Invalidate(); // перерисовує наш юзерконтрол
        }
        /// <summary>
        /// Metoda odpowiada za wyłolanie FireTank w projekcie
        /// </summary>
        /// <param name="e"></param>
        private void DrawFireTank(PaintEventArgs e)
        {
            foreach(FireTank ft in model.FireTank)
                e.Graphics.DrawImage(ft.CurentImg, new Point(ft.X, ft.Y));
        }
        /// <summary>
        /// Metoda odpowiada za wyłolanie Projectile w projekcie
        /// </summary>
        /// <param name="e"></param>
        private void DrawProjectile(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Projectile.Img, new Point(model.Projectile.X, model.Projectile.Y));
        }
        /// <summary>
        /// Metoda odpowiada za wyłolanie Packmena w projekcie
        /// </summary>
        /// <param name="e"></param>
        private void DrawPackman(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.Packman.CurentImg, new Point(model.Packman.X, model.Packman.Y));
        }
        /// <summary>
        /// Metoda odpowiada za wyłolanie Jabłek w projekcie
        /// </summary>
        /// <param name="e"></param>
        private void DrawApple(PaintEventArgs e)
        {
            for (int i = 0; i < model.Apples.Count; i++)
                e.Graphics.DrawImage(model.Apples[i].Img, new Point(model.Apples[i].X, model.Apples[i].Y));
            //foreach (Apple a in model.Apples)
              //  e.Graphics.DrawImage(a.Img, new Point(a.X, a.Y));
        }
        /// <summary>
        /// Metoda odpowiada za wyłolanie czowgów w projekcie
        /// </summary>
        /// <param name="e"></param>
        private void DrawTank(PaintEventArgs e)
        {
            for (int i = 0; i < model.Tanks.Count; i++)
                e.Graphics.DrawImage(model.Tanks[i].CurentImg, new Point(model.Tanks[i].X, model.Tanks[i].Y)); //розташування танка // рисує танки на екрані
        }
        /// <summary>
        /// Metoda odpowiada za wyłolanie scian w projekcie
        /// </summary>
        /// <param name="e"></param>
        private void DarwWall(PaintEventArgs e)
        {
            for (int y = 20; y < 260; y += 40)
                for (int x = 20; x < 260; x += 40)
                    e.Graphics.DrawImage(model.wall.Img, new Point(x, y));
        }
        /// <summary>
        /// Metoda odpowiada za rysowanie formy, rysuje metod Draw i peredaje parametr e
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e) //Відповідає за прорисовку форми// Та метода рисує метод Дров і передає параметр е
        {
            Draw(e);
        }
    }
}
