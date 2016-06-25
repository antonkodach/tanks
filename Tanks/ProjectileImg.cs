using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Tanks
{
    /// <summary>
    /// Klas twoże kulu i rozkrenca je w potrzebnu nam strone kiedy strzeliamy
    /// </summary>
    class ProjectileImg
    {
        Image up = Properties.Resources.Projectile0_1;

        public Image Up
        {
            get { return up; }
        }
        Image down = Properties.Resources.Projectile01;

        public Image Down
        {
            get { return down; }
        }
        Image left = Properties.Resources.Projectile_10;

        public Image Left
        {
            get { return left; }
        }
        Image right = Properties.Resources.Projectile10;

        public Image Right
        {
            get { return right; }
        }

      
    }
}
