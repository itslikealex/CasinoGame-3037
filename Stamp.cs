using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Casino
{
    public class Stamp
    {
        public Image GetImage;
        private int StampID;
        private string StampName;
        private int PayOut;
        public Image Image1;
        public Stamp(int id)
        {
            if (id == 0)
            {
                GetImage = Casino.Properties.Resources.bar;
                //Image1 = Image.FromFile("bar.png");
                StampName = "Bar";
                PayOut = 1;
                StampID = id;

            }
            else if (id == 1)
            {
                GetImage = Casino.Properties.Resources.apple;
                StampName = "apple";
                PayOut = 2;
                StampID = id;


            }
            else if (id == 2)
            {
                GetImage = Casino.Properties.Resources.banana;
                StampName = "banana";
                PayOut = 2;
                StampID = id;


            }
            else if (id == 3)
            {
                GetImage = Casino.Properties.Resources.grape;
                StampName = "grape";
                PayOut = 3;
                StampID = id;


            }
            else if (id == 4)
            {
                GetImage = Casino.Properties.Resources.orange;
                StampName = "orange";
                PayOut = 4;
                StampID = id;
                StampID = id;


            }
            else if (id == 5)
            {
                GetImage = Casino.Properties.Resources.strawberry;
                StampName = "strawberry";
                PayOut = 5;
                StampID = id;


            }
            else if (id == 6)
            {
                GetImage = Casino.Properties.Resources.cherry;
                StampName = "cherry";
                PayOut = 3;
                StampID = id;

            }
            else if (id == 7)
            {
                GetImage = Casino.Properties.Resources.gem;
                StampName = "gem";
                PayOut = 7;
                StampID = id;

            }
            else
            {
                GetImage = Casino.Properties.Resources.jackpot;
                StampName = "jackpot";
                PayOut = 10;
                StampID = 8;

            }

        }
        public Image DisplayImage()
        {
            return GetImage;
        }
        public string Display()
        {
            return StampName;
        }
        public int GetID()
        {
            return StampID;
        }
        public int GetPayOut()
        {
            return PayOut;
        }
    }
}
