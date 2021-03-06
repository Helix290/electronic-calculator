﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        int input;
        int point_mode = 0, point_count = 0, calc_count = 0, calc_log, reset = 0;
        String tmp_display = " ", main_display = "";
        double i, j = 0;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";

        }

        private void calculation()
        {
            if(calc_count == 0) j = i;
            switch (calc_log)
            {
                case 1:
                    j += i;
                    break;
                case 2:
                    j -= i;
                    break;
                case 3:
                    j *= i;
                    break;
                case 4:
                    j /= i;
                    break;
            }
            i = 0;
        }

        private void display(int a)
        {
            if(point_mode == 0)
            {
                i *= 10;
                i += a;
                label1.Text = Convert.ToString(i);
            }
            else
            {
                double b;
                point_count += 1;
                b = a * Math.Pow(0.1, point_count);
                i += b;

                main_display += Convert.ToString(a);
                label1.Text = main_display;
            }
                          
        }

        private void point_clear()
        {
            if(point_mode != 0)
            {
                point_mode = 0;
                point_count = 0;
            }
        }

        private void subdisplay(String a)
        {
            label2.Text = Convert.ToString(a);
        }

        private void displayreload()
        {
            label1.Text = Convert.ToString(i);
        }

        private void allclear()
        {
            i = 0;
            j = 0;
            calc_count = 0;
            calc_log = 0;
            point_clear();
            tmp_display = " ";
            main_display = "";
            reset = 0;
            display(0);
            subdisplay(tmp_display);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 0;
            display(input);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 1;
            display(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 2;
            display(input);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 3;
            display(input);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 4;
            display(input);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 5;
            display(input);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 6;
            display(input);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 7;
            display(input);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 8;
            display(input);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (reset == 1) allclear();
            input = 9;
            display(input);
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            if (point_mode == 0)
            {
                if (reset == 1) allclear();
                point_mode = 1;
                main_display = Convert.ToString(i);
                main_display += ".";
                label1.Text = main_display;
            }
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            tmp_display = tmp_display + i + "＝";
            subdisplay(tmp_display);
            calculation();
            point_clear();
            reset = 1;
            label1.Text = Convert.ToString(j);
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            tmp_display = tmp_display + i + "＋";
            subdisplay(tmp_display);
            calculation();
            calc_count += 1;
            calc_log = 1;
            point_clear();
            reset = 0;
            label1.Text = Convert.ToString(j);
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            tmp_display = tmp_display + i + "－";
            subdisplay(tmp_display);
            calculation();
            calc_count += 1;
            calc_log = 2;
            point_clear();
            reset = 0;
            label1.Text = Convert.ToString(j);
        }

        private void button_kakeru_Click(object sender, EventArgs e)
        {
            tmp_display = tmp_display + i + "×";
            subdisplay(tmp_display);
            calculation();
            calc_count += 1;
            calc_log = 3;
            point_clear();
            reset = 0;
            label1.Text = Convert.ToString(j);
        }

        private void button_waru_Click(object sender, EventArgs e)
        {
            tmp_display = tmp_display + i + "÷";
            subdisplay(tmp_display);
            calculation();
            calc_count += 1;
            calc_log = 4;
            point_clear();
            reset = 0;
            label1.Text = Convert.ToString(j);
        }

        private void button_bs_Click(object sender, EventArgs e)
        {
            if(point_mode == 0) i = (i / 10) - ((i % 10) / 10);
            else
            {
                double tmp;
                tmp = i * Math.Pow(10, point_count);
                tmp = (tmp / 10) - ((tmp % 10) / 10);
                point_count -= 1;
                i = tmp * Math.Pow(0.1, point_count);
                if (point_count == 0) point_mode = 0;
            }
            if (point_count == 0) label1.Text = Convert.ToString(i);
            else
            {
                int length = main_display.Length;
                main_display = main_display.Remove(length - 1);
                label1.Text = main_display;
            }
        }

        

        private void button_clear_Click(object sender, EventArgs e)
        {
            i = 0;
            main_display = "";
            point_clear();
            display(0);
        }

        private void button_allclear_Click(object sender, EventArgs e)
        {
            allclear();
        }

    }
}
