using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form2 : Form
    {
        int[,] mas = new int[3, 3]; // создание массива 
        int Player0score = 0; // обьявление переменной 1 игрока
        int Player1score = 0; // обьявление переменной 2 игрока
        int StepCount = 0; // обьявление переменной считывающей очки

        List<MyBtn> btns = new List<MyBtn>();
        int activeGo = 0; // 0 - 0, 1 - X  
        int firstGo = 0; // Кто ходит первым. 0 - 0, 1 - X 

        Label lblX;
        Label lbl0;

        public Form2()
        {
            InitializeComponent();
            // добавление кнопок c формы в массив

            btns.Add(new MyBtn(btn22, 1, 1));
            btns.Add(new MyBtn(btn11, 0, 0));
            btns.Add(new MyBtn(btn13, 0, 2));
            btns.Add(new MyBtn(btn31, 2, 0));
            btns.Add(new MyBtn(btn33, 2, 2));
            btns.Add(new MyBtn(btn12, 0, 1));
            btns.Add(new MyBtn(btn21, 1, 0));
            btns.Add(new MyBtn(btn23, 1, 2));
            btns.Add(new MyBtn(btn32, 2, 1));

            ResetGame();
            ShowScore();

           }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResetGame(); // функция сброса игры

        }
        private void ResetGame()
        {
            StepCount = 0;
            // Сброс таблицы состояний кнопок 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mas[i, j] = 0;
                }
            }
            // Сброс текста кнопок на ""
            for (int i = 0; i < btns.Count; i++)
            {
                btns[i].button.Text = "";
            }

            Random random = new Random();

            activeGo = 1;

            firstGo = random.Next(0, 2);

            if (firstGo == 1)
            {
                lblX = lblStep0;
                lbl0 = lblStep1;
            }
            else
            {
                lblX = lblStep1;
                lbl0 = lblStep0;

            }

            lblX.Text = "X";
            lbl0.Text = "0";
            ShowScore();

            if (cbModePC.Checked == true)
            {
                // Если активный игрок игрок 1 
                if ((activeGo == 1 ^ firstGo == 1))
                    GoPC();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) // нажатие на кнопку обнуляет результаты
        {
            ResetGame();
        }

        private void btnXX_Click(object sender, EventArgs e)
        {
            // для всех кнопок
            Button btn = sender as Button;
            MyBtn myBtn = null;

            foreach (MyBtn item in btns)
            {
                if (item.button == btn)
                {
                    myBtn = item;
                    break;
                }

            }

            if (btn.Text == "")
            {
                StepCount++;
                if (activeGo == 1)
                {
                    myBtn.button.Text = "X";
                    activeGo = 0;
                    mas[myBtn.i, myBtn.j] = 1;

                }
                else
                {
                    myBtn.button.Text = "0";
                    activeGo = 1;
                    mas[myBtn.i, myBtn.j] = 2;
                }

                if (ChechGo()) // добавление очков победителю в игре
                {
                    MessageBox.Show("Выигрыш");
                    if (activeGo == 1 ^ firstGo == 1)
                    {
                        Player0score++;
                    }
                    else
                    {
                        Player1score++;
                    }
                    ResetGame();

                }
                else
                if (StepCount == 9)
                {
                    MessageBox.Show("Ничья");
                    ResetGame();
                }
                else
                if (cbModePC.Checked == true)
                {
                    // Если активный игрок игрок 1 
                    if ((activeGo == 1 ^ firstGo == 1))
                      GoPC();
                }
                ShowScore();
                
                
            }
        }
        private void ShowScore()
        {

            lblP1.Text = Player0score.ToString();
            lblP2.Text = Player1score.ToString();

            if (activeGo == 1) // ход активного игрока
            {
                lblX.ForeColor = Color.Red; // подстветка активного игрока красным цветом
                lbl0.ForeColor = Color.Black; // подстветка не активного игрока черным цветом
            }
            else
            {
                lblX.ForeColor = Color.Black; // подстветка не активного игрока черным цветом
                lbl0.ForeColor = Color.Red; // подстветка активного игрока красным цветом
            }
        }

        private bool ChechGo() // просчет выигрышных результатов во всех вариантах игры
        {
            bool res = false;

            res = res || (mas[0, 0] == mas[0, 1] && mas[0, 1] == mas[0, 2] && mas[0, 0] != 0); 
            res = res || (mas[1, 0] == mas[1, 1] && mas[1, 1] == mas[1, 2] && mas[1, 0] != 0);
            res = res || (mas[2, 0] == mas[2, 1] && mas[2, 1] == mas[2, 2] && mas[2, 0] != 0);
            res = res || (mas[0, 0] == mas[1, 0] && mas[1, 0] == mas[2, 0] && mas[0, 0] != 0);
            res = res || (mas[0, 1] == mas[1, 1] && mas[1, 1] == mas[2, 1] && mas[0, 1] != 0);
            res = res || (mas[0, 2] == mas[1, 2] && mas[1, 2] == mas[2, 2] && mas[0, 2] != 0);
            res = res || (mas[0, 0] == mas[1, 1] && mas[1, 1] == mas[2, 2] && mas[0, 0] != 0);
            res = res || (mas[0, 2] == mas[1, 1] && mas[1, 1] == mas[2, 0] && mas[0, 2] != 0);

            return res;
        }

        private void cbModePC_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModePC.Checked)
            {
                edP2.Text = "Компьютер";
            } 
            else
            {
                edP2.Text = "Игрок 2";
            }
        }

        private void GoPC()
        {
            // Расчет хода компьютера. 
            // ActiveGO - Противник 
            int PCCode = 0;
            int P1Code = 0; 

            if (activeGo == 0)
            {
                PCCode = 2; // X
                P1Code = 1; // 0
            }
            else
            {
                PCCode = 1; // X
                P1Code = 2; // 0
            }
            // первый рандомный ход комптютера (при котором он бьет по центру и крайним диагоналям, для лучшей игры)
            if (StepCount == 0)
            {
                var random = new Random();
                int btnIndex = random.Next(0, 4);
                btnXX_Click(btns[btnIndex].button, null);
                return;

            }
            // Первый ход... проверка диагоналей 
            if (StepCount == 1)
            {
                foreach (var item in btns)
                {
                   if ( (item.i == 0) & (item.j == 0) & (mas[2, 2] != 0) )
                    {
                        btnXX_Click(item.button, null);
                        return;
                    }

                    if ((item.i == 0) & (item.j == 2) & (mas[2, 0] != 0))
                    {
                        btnXX_Click(item.button, null);
                        return;
                    }
                    if ((item.i == 2) & (item.j == 0) & (mas[0, 2] != 0))
                    {
                        btnXX_Click(item.button, null);
                        return;
                    }
                    if ((item.i == 2) & (item.j == 2) & (mas[0, 0] != 0))
                    {
                        btnXX_Click(item.button, null);
                        return;
                    }

                }
            }

            // Поиск выгрыша
            foreach (var item in btns)
            {
                if (mas[item.i, item.j] == 0)
                {
                    mas[item.i, item.j] = PCCode;
                    if (ChechGo())
                    {
                        btnXX_Click(item.button, null);
                        return;
                    }
                    mas[item.i, item.j] = 0; 
                }
            }
            // Поиск хода противника  
            foreach (var item in btns)
            {
                if (mas[item.i, item.j] == 0)
                {
                    mas[item.i, item.j] = P1Code;
                    if (ChechGo())
                    {
                        btnXX_Click(item.button, null);
                        return;

                    }
                    mas[item.i, item.j] = 0;
                }
            }
            // Проставка по приоритету. 
            foreach (var item in btns)
            {
                if (mas[item.i, item.j] == 0)
                {
                    btnXX_Click(item.button, null); 
                    return;
                }
            }

        }
        // функция, при котором форма скрывается а не закрывается, для того, чтобы при закрытии игра продолжалась с того момента на котором закончили
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }

    


   
}
