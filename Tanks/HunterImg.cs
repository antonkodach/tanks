using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    /// <summary>
    /// Clas podstawia podstawia potrzebne zdjecia Huntera przy ruchu w różne strony
    /// </summary>
    class HunterImg
    {
        Image[] up = new Image[] {
            Properties.Resources.HunterImg0_1, 
            Properties.Resources.HunterImg0_11, 
            Properties.Resources.HunterImg0_12, 
            Properties.Resources.HunterImg0_13,
            Properties.Resources.HunterImg0_14 };


        Image[] down = new Image[] {
            Properties.Resources.HunterImg01, 
            Properties.Resources.HunterImg011, 
            Properties.Resources.HunterImg012, 
            Properties.Resources.HunterImg013,
            Properties.Resources.HunterImg014 };


        Image[] right = new Image[] { 
            Properties.Resources.HunterImg10, 
            Properties.Resources.HunterImg101, 
            Properties.Resources.HunterImg102, 
            Properties.Resources.HunterImg103,
            Properties.Resources.HunterImg104 };


        Image[] left = new Image[] { 
            Properties.Resources.HunterImg_10, 
            Properties.Resources.HunterImg_101, 
            Properties.Resources.HunterImg_102, 
            Properties.Resources.HunterImg_103,
            Properties.Resources.HunterImg_104 };


        public Image[] Up
        {
            get { return up; }
        }

        public Image[] Down
        {
            get { return down; }
        }

        public Image[] Right
        {
            get { return right; }
        }

        public Image[] Left
        {
            get { return left; }
        }
        
    }
}
