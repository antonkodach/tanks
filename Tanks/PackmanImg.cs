using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Tanks
{
    /// <summary>
    /// Podstawia po kolejnoci zdjęcia w kazdą strone ruchu
    /// </summary>
    class PackmanImg
    {
        Image[] up = new Image[] {
            Properties.Resources.PackmanImg0_1, 
            Properties.Resources.PackmanImg0_11, 
            Properties.Resources.PackmanImg0_12, 
            Properties.Resources.PackmanImg0_13,
            Properties.Resources.PackmanImg0_14 };


        Image[] down = new Image[] {
            Properties.Resources.PackmanImg01, 
            Properties.Resources.PackmanImg011, 
            Properties.Resources.PackmanImg012, 
            Properties.Resources.PackmanImg013,
            Properties.Resources.PackmanImg014 };


        Image[] right = new Image[] { 
            Properties.Resources.PackmanImg10, 
            Properties.Resources.PackmanImg101, 
            Properties.Resources.PackmanImg102, 
            Properties.Resources.PackmanImg103,
            Properties.Resources.PackmanImg104 };


        Image[] left = new Image[] { 
            Properties.Resources.PackmanImg_10, 
            Properties.Resources.PackmanImg_101, 
            Properties.Resources.PackmanImg_102, 
            Properties.Resources.PackmanImg_103,
            Properties.Resources.PackmanImg_104 };


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
