using System.Drawing;
using System;
using System.Windows.Forms;

namespace Крестики_Нолики
{
    public partial class Form1 : Form
    {
        private int x = 12, y = 12;
        private Button[,] buttons = new Button[3, 3];
        private int player;
        public Form1()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 800;
            player = 1;
            label1.Text = "Ход первого игрока";
            for (int j = 0; j < buttons.Length / 3; j++)
            {
                for (int i = 0; i < buttons.Length / 3; i++)
                {
                    buttons[j, i] = new Button();
                    buttons[j, i].Size = new Size(200, 200);
                }
            }
            setButtons();
        }
        private void setButtons()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    buttons[j, i].Location = new Point(12 + 206 * j, 12 + 206 * i);
                    buttons[j, i].Click += button1_Click;
                    buttons[j, i].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);
                    buttons[j, i].Text = "";
                    this.Controls.Add(buttons[j, i]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "X");
                    player = 2;
                    label1.Text = "Ход второго игрока";
                    break;
                case 2:
                    sender.GetType().GetProperty("Text").SetValue(sender, "O");
                    player = 1;
                    label1.Text = "Ход первого игрока";
                    break;
            }
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            checkWin();
        }
        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show("Вы победили!");
            }
        }
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    buttons[j, i].Text = "";
                    buttons[j, i].Enabled = true;
                }
            }
        }
    }
}