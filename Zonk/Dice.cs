using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zonk
{
    public class Dice
    {
        public int sn;
        public int clicks = 0;
        bool stroked;
        bool ingame;
        int num;
        public Bitmap bmp;
        public Dice(int number, bool strk, int serial_number)
        {
            ingame = true;
            sn = serial_number;
            num = number;
            stroked = strk;
            if (stroked)
                bmp = new Bitmap("..\\..\\Resources\\" + num + "_1_stroked.png");
            else
                bmp = new Bitmap("..\\..\\Resources\\" + num + "_1.png");
        }
        public int Num
        {
            set
            {
                this.num = value;
                this.UpdateBitmap();

            }
            get
            {
                return this.num;
            }
        }
        public bool Stroked
        {
            set
            {
                this.stroked = value;
                this.UpdateBitmap();
            }
            get
            {
                return this.stroked;
            }
        }
        public bool Ingame
        {
            set
            {
                this.ingame = value;
                this.stroked = false;
                this.UpdateBitmap();
            }
            get
            {
                return this.ingame;
            }
        }
        void UpdateBitmap()
        {
            if (this.stroked)
                this.bmp = new Bitmap("..\\..\\Resources\\" + this.num + "_1_stroked.png");
            else
                this.bmp = new Bitmap("..\\..\\Resources\\" + this.num + "_1.png");
        }
    }
}
