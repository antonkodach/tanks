using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Tanks
{
    public delegate void STREEP();
    /// <summary>
    /// W tym klasie pobudowana logika do całego projektu
    /// </summary>
    class Model // Будуємо нашу логіку в цьому класі
    {
        public event STREEP changeStreep;
        int collectedApples;
        int sizeField;
        int amountTanks;
        int amountApples;
        public int speedGame;
        

        public GameStatus gameStatus;

        Random r;

        Projectile projectile;

        internal Projectile Projectile
        {
            get { return projectile; }
        }
        Packman packman;

        internal Packman Packman
        {
            get { return packman; }
        }

        List<Tank> tanks;
        internal List<Tank> Tanks
        {
            get { return tanks; }
        }
        List<FireTank> fireTank;
        internal List<FireTank> FireTank
        {
            get { return fireTank; }
        }
        List<Apple> apples;
        internal List<Apple> Apples
        {
            get { return apples; }
        }
        
        
        public Wall wall;
        /// <summary>
        /// Metoda kieruje i manipuliuje wszystkiema obiektami w tym projekcie
        /// </summary>
        /// <param name="sizeField"> rozmiar pola</param>
        /// <param name="amountTanks"> ilosć czowgów</param>
        /// <param name="amountApples">ilosć jabłuk</param>
        /// <param name="speedGame">szybkosć gry</param>
        public Model(int sizeField, int amountTanks, int amountApples, int speedGame) // Керує і маніпулює всіма обєктами в нашій грі
        {
            r = new Random();

            

            this.sizeField = sizeField;
            this.amountTanks = amountTanks;
            this.amountApples = amountApples;
            this.speedGame = speedGame;

            NewGame();
        }
        
        private void CreateApples()
        {
            CreateApples(0);
        }
        /// <summary>
        /// Tworzenie i dodawanie nowych jabłuk na pole gry
        /// </summary>
        /// <param name="newApples">dodaje nowe jabłko, kiedy Packmen wezmie jedne</param>
        private void CreateApples(int newApples)
        {
            int x, y;
            while (apples.Count < amountApples + newApples)
            {
                x = r.Next(6) * 40;
                y = r.Next(6) * 40;
                bool flag = true;

                foreach (Apple a in apples)
                    if (a.X == x && a.Y == y)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    apples.Add(new Apple(x, y));
            }
        }
        /// <summary>
        /// Tworzenie czowgów na pole gry
        /// </summary>
        private void CreateTanks()
        {
            int x, y;
            while (tanks.Count < amountTanks+1)
            {
                if (tanks.Count == 0)
                    tanks.Add(new Hunter(sizeField, r.Next(6) * 40, r.Next(6) * 40));


                x = r.Next(6) * 40;
                y = r.Next(6) * 40;
                bool flag = true;

                foreach (Tank t in tanks)
                    if (t.X == x && t.Y == y)
                    {
                        flag = false;
                        break;
                    }

                if (flag)
                    tanks.Add(new Tank(sizeField, x, y));
            }
        }
        /// <summary>
        /// Odpowiada za włączenie/wyłączenie gry,podbicie czowgów,kierowanie chowgami i Hunterem,
        /// podbiór jabłek packmenem, wyznacza gameStatus
        /// </summary>
        public void Play() // Odpowiada za włączanie i wyłączanie gry
        {
            while (gameStatus == GameStatus.playing)
            {
                Thread.Sleep(speedGame);

                projectile.Run();
                packman.Run();
                ((Hunter)tanks[0]).Run(packman.X, packman.Y);
                for (int i = 1; i < tanks.Count; i++)
                    tanks[i].Run();

                foreach (FireTank ft in fireTank)
                    ft.Fire();

                for (int i = 1; i < tanks.Count; i++) // Підбиття танків ворожих
                    if ((projectile.X - tanks[i].X) < 13 && (projectile.Y - tanks[i].Y) < 13 &&
                        (projectile.X - tanks[i].X) > 7 && (projectile.Y - tanks[i].Y) > 7)
                    {
                        fireTank.Add(new FireTank(tanks[i].X, tanks[i].Y));
                        tanks.RemoveAt(i);
                        projectile.DefaultSetting();
                    }

                for (int i = 0; i < tanks.Count - 1; i++)
                    for (int j = i + 1; j < tanks.Count; j++)
                        if (
                                (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && (tanks[i].Y == tanks[j].Y))
                            ||
                                (Math.Abs(tanks[i].Y - tanks[j].Y) <= 20 && (tanks[i].X == tanks[j].X))
                            ||
                                (Math.Abs(tanks[i].X - tanks[j].X) <= 20 && Math.Abs(tanks[i].Y - tanks[j].Y) <= 20)
                            )
                        {
                            if (i == 0)
                                ((Hunter)tanks[i]).TurnAround();
                            else
                                tanks[i].TurnAround();

                            tanks[j].TurnAround();
                        }

                for (int i = 0; i < tanks.Count; i++)
                    if
                        (
                                (Math.Abs(tanks[i].X - packman.X) <= 19 && (tanks[i].Y == packman.Y))
                            ||
                                (Math.Abs(tanks[i].Y - packman.Y) <= 19 && (tanks[i].X == packman.X))
                            ||
                                (Math.Abs(tanks[i].X - packman.X) <= 19 && Math.Abs(tanks[i].Y - packman.Y) <= 19)
                        )
                    {
                        gameStatus = GameStatus.loozer;
                        if (changeStreep != null)
                            changeStreep();
                    }

                for (int i = 0; i < apples.Count; i++)
                    if (Math.Abs(packman.X - apples[i].X) < 3 && Math.Abs(packman.Y - apples[i].Y) < 3)
                    {
                        apples[i] = new Apple(step += 30, 280);
                        CreateApples(++collectedApples);
                    }
                if (collectedApples > 4)
                {
                    gameStatus = GameStatus.winer;
                    if (changeStreep != null)
                        changeStreep();
                }
            }
        }
        int step;
        /// <summary>
        /// Metoda, która odpowiada za włączenie nowej gry, nadaje początkowe polożenia obiektam na początku każdej nowej gry
        /// </summary>
        internal void NewGame()
        {
            collectedApples = 0; // 0 jabluk na poczatku kazdoji gry
            step = -30;
            projectile = new Projectile();
            packman = new Packman(sizeField);
            tanks = new List<Tank>();
            fireTank = new List<FireTank>();
            apples = new List<Apple>();

            CreateTanks();
            CreateApples();
            wall = new Wall();

            gameStatus = GameStatus.stoping;
        }
    }
}
