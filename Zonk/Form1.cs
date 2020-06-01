using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Zonk
{
    public partial class Form1 : Form
    {
        public int tick,
            round = 1,
            stage = 0,
            points = 0,
            roundpoints = 0,
            otobrano = 0;
        int c1, c2, c3, c4, c5, c6;
        Random rnd = new Random();
        Dice d1 = new Dice(1, false,1);
        Dice d2 = new Dice(2, false,2);
        Dice d3 = new Dice(3, false,3);
        Dice d4 = new Dice(4, false,4);
        Dice d5 = new Dice(5, false,5);
        Dice d6 = new Dice(6, false,6);
        WinForm wf = new WinForm();
        public Form1()
        {
            InitializeComponent();
        }
        public int Points
        {
            get
            {
                return points;
            }
        }
        //Метод для получения PictureBox по его номеру
        PictureBox GetPictureBox(int n)
        {
            switch (n)
            {
                case 1:
                    return pB_dice_1;
                case 2:
                    return pB_dice_2;
                case 3:
                    return pB_dice_3;
                case 4:
                    return pB_dice_4;
                case 5:
                    return pB_dice_5;
                case 6:
                    return pB_dice_6;
            }
            return pb_test;
        }
        //Метод для получения объекта класса Dice по его номеру
        public Dice GetDice(int n)
        {
            switch (n)
            {
                case 1:
                    return d1;
                case 2:
                    return d2;
                case 3:
                    return d3;
                case 4:
                    return d4;
                case 5:
                    return d5;
                case 6:
                    return d6;
            }
                return new Dice(0, false, 0);

        }
        //Метод для проверки того, что не выпали кубики, с которыми заканчивается раунд
        private void CheckDices()
        {
            int comb = 0,
                have = 0;
            for (int i = 1; i < 7; i++)
            {
                if (GetDice(i).Ingame && (GetDice(i).Num == 1 || GetDice(i).Num == 5))
                    have++;
            }
            for (int i = 1; i < 7; i++)
            {
                for(int j = 1; j<7;j++)
                {
                    if (GetDice(j).Ingame && GetDice(j).Num == i)
                        comb++;
                }
                if (comb >= 3)
                    have++;
                comb = 0;
            }
            if (have == 0)
            {
                MessageBox.Show("Неудача");
                NextroundWithoutPoints();
            }
        }
        //Метод для посдчета очков и контролирования основных кнопок во время выбора костей
        private void CountPoints()
        {
            otobrano = 0;
            bool b = false;
            bool[] bcomb = new bool[7];
            int comb = 0;
            for(int i = 1; i<7;i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    if (GetDice(j).Stroked && GetDice(j).Num == i)
                            comb++;
                }
                switch (comb)
                {
                    case 1:
                        otobrano += SinglePoints(i);
                        break;
                    case 2:
                        otobrano += SinglePoints(i) * 2;
                        break;
                    case 3:
                        otobrano += TriplePoints(i);
                        break;
                    case 4:
                        otobrano += TriplePoints(i) * 2;
                        break;
                    case 5:
                        otobrano += TriplePoints(i) * 3;
                        break;
                    case 6:
                        otobrano += TriplePoints(i) * 4;
                        break;
                }
                if (comb >= 3 && (i != 1 || i != 5))
                {
                    bcomb[i] = true;
                }
                comb = 0;
            }
            for (int i = 1; i < 7; i++)
            {
                if (GetDice(i).Stroked && ((GetDice(i).Num == 1 || GetDice(i).Num == 5)))
                    b = true;
                if (bcomb[i])
                    b = true;
            }
            for (int i = 1; i < 7; i++)
            {
                if (bcomb[GetDice(i).Num] == false && GetDice(i).Stroked && (GetDice(i).Num != 1 && GetDice(i).Num != 5))
                    b = false;
            }
            if (b)
            {
                btn_wd.Enabled = true;
                btn_end.Enabled = true;
            }
            else
            {
                btn_wd.Enabled = false;
                btn_end.Enabled = false;
            }
            lb_otobrano.Text = "Отобрано: " + otobrano;
        }
        //метод, который считает очки без комбо
        int SinglePoints(int dicenum)
        {
            if (dicenum == 1)
                return 100;
            if (dicenum == 5)
                return 50;
            else return 0;
        }
        //метод, который считает комбо-очки
        int TriplePoints(int dicenum)
        {
            switch (dicenum)
            {
                case 1:
                    return 1000;                   
                case 2:
                    return 200;
                case 3:
                    return 300;
                case 4:
                    return 400;
                case 5:
                    return 500;
                case 6:
                    return 600;
            }
            return 0;
        }
        //Метод для перехода к следующему раунду
        private void Nextround()
        {
            round++;
            if (round < 6)
            {
                stage = 0;
                btn_throw.Enabled = true;
                btn_end.Enabled = false;
                btn_wd.Enabled = false;
                lb_round.Text = "Раунд: " + round;
                points += roundpoints;
                roundpoints = 0;
                lb_points.Text = "Всего очков: " + points;
                lb_round_points.Text = "Очки за раунд: " + roundpoints;
                for (int i = 1; i < 7; i++)
                {
                    if (GetDice(i).Ingame == false)
                    {
                        GetDice(i).Ingame = true;
                        flp_default.Controls.Add(GetPictureBox(i));
                    }
                }
            }
            else
            {
                points += roundpoints;
                roundpoints = 0;
                btn_throw.Enabled = false;
                btn_wd.Enabled = false;
                btn_end.Enabled = false;
                StreamWriter sw = new StreamWriter("..\\..\\points.txt");
                sw.WriteLine(points);
                sw.Close();
                wf.Show();
                Hide();
            }
        }
        //Метод для перехода к след. раунда без учета накопленных очков
        void NextroundWithoutPoints()
        {
            round++;
            if (round < 6)
            {
                stage = 0;
                btn_throw.Enabled = true;
                btn_end.Enabled = false;
                btn_wd.Enabled = false;
                lb_round.Text = "Раунд: " + round;
                roundpoints = 0;
                lb_points.Text = "Всего очков: " + points;
                lb_round_points.Text = "Очки за раунд: " + roundpoints;
                for (int i = 1; i < 7; i++)
                {
                    if (GetDice(i).Ingame == false)
                    {
                        GetDice(i).Ingame = true;
                        flp_default.Controls.Add(GetPictureBox(i));
                    }
                }
            }
            else
            {
                points += roundpoints;
                roundpoints = 0;
                btn_throw.Enabled = false;
                btn_wd.Enabled = false;
                btn_end.Enabled = false;
                StreamWriter sw = new StreamWriter("..\\..\\points.txt");
                sw.WriteLine(points);
                sw.Close();
                wf.Show();
                Hide();
            }
        }
        //Метод считает кол-во обведенных костей
        int NumberofStroked()
        {
            int res = 0;
            for (int i = 1; i < 7; i++)
            {
                if (GetDice(i).Stroked)
                    res++;
            }
            return res;
        }
        //метод считает кол-во костей в игре
        int NumberInGame()
        {
            int res = 0;
            for (int i = 1; i < 7; i++)
            {
                if (GetDice(i).Ingame)
                    res++;
            }
            return res;
        }
        //Событие для вызова инструкции
        private void btn_Instructions_Click(object sender, EventArgs e)
        {
            InstrForm fi = new InstrForm();
            fi.Show();
        }
        //Событие "бросить кубик"
        private void btn_throw_Click(object sender, EventArgs e)
        {
            if (stage == 0)
            {
                SoundPlayer sp = new SoundPlayer("..\\..\\sound.wav");
                sp.Play();
                timer1.Enabled = true;
                btn_throw.Enabled = false;
                stage++;
            }
        }
        //Таймер при броске кубиков
        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            if (d1.Ingame == true)
            {
                c1 = rnd.Next(1, 7);
                d1.Num = c1;
                pB_dice_1.Image = d1.bmp;
            }

            if (d2.Ingame == true)
            {
                c2 = rnd.Next(1, 7);
                d2.Num = c2;
                pB_dice_2.Image = d2.bmp;
            }

            if (d3.Ingame == true)
            {
                c3 = rnd.Next(1, 7);
                d3.Num = c3;
                pB_dice_3.Image = d3.bmp;
            }

            if (d4.Ingame == true)
            {
                c4 = rnd.Next(1, 7);
                d4.Num = c4;
                pB_dice_4.Image = d4.bmp;
            }

            if (d5.Ingame == true)
            {
                c5 = rnd.Next(1, 7);
                d5.Num = c5;
                pB_dice_5.Image = d5.bmp;
            }

            if (d6.Ingame == true)
            {
                c6 = rnd.Next(1, 7);
                d6.Num = c6;
                pB_dice_6.Image = d6.bmp;
            }
            if (tick == 10)
            {
                timer1.Stop();
                tick = 0;
                CheckDices();
            }
        }
        //Событие "Записать счет"
        private void btn_wd_Click(object sender, EventArgs e)
        {
            if (stage == 1 && NumberofStroked() != 0)
            {
                    for (int i = 1; i < 7; i++)
                    {
                        if (GetDice(i).Stroked && GetDice(i).Ingame)
                        {
                            flp_Dices.Controls.Add(GetPictureBox(i));
                            GetDice(i).Ingame = false;
                            GetPictureBox(i).Image = GetDice(i).bmp;
                        }
                    }
                stage--;
                btn_throw.Enabled = true;
                btn_wd.Enabled = false;
                btn_end.Enabled = false;
                roundpoints += otobrano;
                lb_round_points.Text = "Очки за раунд: " + roundpoints;
                otobrano = 0;
                lb_otobrano.Text = "Отобрано: " + otobrano;
                if (NumberInGame() == 0)
                    Nextround();

            }
        }
        //Событие "Закончить раунд"
        private void btn_end_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 7; i++)
            {
                if (GetDice(i).Stroked && GetDice(i).Ingame)
                {
                    GetDice(i).Stroked = false;
                    GetPictureBox(i).Image = GetDice(i).bmp;
                }
            }
            roundpoints += otobrano;
            lb_round_points.Text = "Очки за раунд: " + roundpoints;
            otobrano = 0;
            lb_otobrano.Text = "Отобрано: " + otobrano;
            Nextround();
        }
        //События кликания на кубики
        private void pB_dice_1_Click(object sender, EventArgs e)
        {
            if (stage != 0)
            {
                d1.clicks++;
                if (d1.clicks % 2 == 1)
                {
                    d1.Stroked = true;
                    pB_dice_1.Image = d1.bmp;
                }
                else
                {
                    d1.Stroked = false;
                    pB_dice_1.Image = d1.bmp;
                }
                CountPoints();
            }
        }

        private void pB_dice_2_Click(object sender, EventArgs e)
        {
            if (stage != 0)
            {
                d2.clicks++;
                if (d2.clicks % 2 == 1)
                {
                    d2.Stroked = true;
                    pB_dice_2.Image = d2.bmp;
                }
                else
                {
                    d2.Stroked = false;
                    pB_dice_2.Image = d2.bmp;
                }
                CountPoints();
            }
        }

        private void pB_dice_3_Click(object sender, EventArgs e)
        {
            if (stage != 0)
            {
                d3.clicks++;
                if (d3.clicks % 2 == 1)
                {
                    d3.Stroked = true;
                    pB_dice_3.Image = d3.bmp;
                }
                else
                {
                    d3.Stroked = false;
                    pB_dice_3.Image = d3.bmp;
                }
                CountPoints();
            }
        }

        private void pB_dice_4_Click(object sender, EventArgs e)
        {
            if (stage != 0)
            {
                d4.clicks++;
                if (d4.clicks % 2 == 1)
                {
                    d4.Stroked = true;
                    pB_dice_4.Image = d4.bmp;
                }
                else
                {
                    d4.Stroked = false;
                    pB_dice_4.Image = d4.bmp;
                }
                CountPoints();
            }
        }

        private void pB_dice_5_Click(object sender, EventArgs e)
        {
            if (stage != 0)
            {
                d5.clicks++;
                if (d5.clicks % 2 == 1)
                {
                    d5.Stroked = true;
                    pB_dice_5.Image = d5.bmp;
                }
                else
                {
                    d5.Stroked = false;
                    pB_dice_5.Image = d5.bmp;
                }
                CountPoints();
            }
        }

        private void pB_dice_6_Click(object sender, EventArgs e)
        {
            if (stage != 0)
            {
                d6.clicks++;
                if (d6.clicks % 2 == 1)
                {
                    d6.Stroked = true;
                    pB_dice_6.Image = d6.bmp;
                }
                else
                {
                    d6.Stroked = false;
                    pB_dice_6.Image = d6.bmp;
                }
                CountPoints();
            }
        }
    }
}
