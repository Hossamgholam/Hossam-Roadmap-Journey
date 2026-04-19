using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tic_tac_toc.Properties;

namespace tic_tac_toc
{
    public partial class Form1 : Form
    {
        enum enPlayerTurn
        {
            player1,player2
        }
        enum enWinner
        {
            player1,
            player2,
            draw,
            InProgress
           
        }
        struct GameStats
        {
            public enWinner winner;
            public bool gameOver;
            public short playCount;
        }
        
        enPlayerTurn playerTurn= enPlayerTurn.player1;
        GameStats gameStats = new GameStats();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White, 10);
            pen.StartCap=System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap=System.Drawing.Drawing2D.LineCap.Round;

            
            e.Graphics.DrawLine(pen, 400, 80, 400, 450);
            e.Graphics.DrawLine(pen, 550, 80, 550, 450);

            e.Graphics.DrawLine(pen, 280, 200, 660, 200);
            e.Graphics.DrawLine(pen, 280, 330, 660, 330);
        }

        public void EndGame()
        {
            lbPlayerTurn.Text="Game over";
            switch (gameStats.winner)
            {
                case enWinner.player1:
                    lbWinner.Text="player 1";
                    break;
                case enWinner.player2:
                    lbWinner.Text="player 2";
                    break;
                case enWinner.draw:
                    lbWinner.Text="draw";
                    break;
            }
            MessageBox.Show("game over");
        }
        public bool checkValue(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString()!="?"&&btn1.Tag.ToString()==btn3.Tag.ToString()&& btn1.Tag.ToString()==btn2.Tag.ToString()) {
                btn1.BackColor=Color.GreenYellow;
                btn2.BackColor=Color.GreenYellow;
                btn3.BackColor=Color.GreenYellow;

                if (btn1.Tag.ToString()=="X")
                {
                    gameStats.winner=enWinner.player1;
                    gameStats.gameOver=true;
                    EndGame();
                    return true;
                }
                else
                {
                    gameStats.winner=enWinner.player2;
                    gameStats.gameOver=true;
                    EndGame();
                    return true;
                }
            }
            gameStats.gameOver = false;
            return false;
        }
        public void CheckWinner()
        {
            if (checkValue(btn1, btn2, btn3)) return;

            if(checkValue(btn4,btn5,btn6)) return;

            if(checkValue(btn7,btn8,btn9)) return;

            if (checkValue(btn1, btn4, btn7)) return;

            if (checkValue(btn2, btn5, btn8)) return;

            if (checkValue(btn3, btn6, btn9)) return;

            if (checkValue(btn1, btn5, btn9)) return;

            if (checkValue(btn3, btn5, btn7)) return;
                
        }
        public void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString()=="?")
            {
                switch (playerTurn)
                {
                    case enPlayerTurn.player1:
                        btn.Image=Resources.X;
                        playerTurn= enPlayerTurn.player2;
                        lbPlayerTurn.Text="player 2";
                        gameStats.playCount++;
                        btn.Tag="X";
                        CheckWinner();
                        break;
                    case enPlayerTurn.player2:
                        btn.Image=Resources.O;
                        playerTurn= enPlayerTurn.player1;
                        lbPlayerTurn.Text="player 1";
                        gameStats.playCount++;
                        btn.Tag="O";
                        CheckWinner();
                        break;
                        
                }

            }
            else
            {
                MessageBox.Show("wrong chooice", "worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (gameStats.playCount==9)
            {
                gameStats.gameOver=true;
                gameStats.winner=enWinner.draw;
                EndGame();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        //make one event for all
        //private void btn1_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn1);
        //}
        //private void btn2_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn2);
        //}
        //private void btn3_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn3);
        //}
        //private void btn4_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn4);
        //}
        //private void btn5_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn5);
        //}
        //private void btn6_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn6);
        //}
        //private void btn7_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn7);
        //}
        //private void btn8_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn8);
        //}
        //private void btn9_Click(object sender, EventArgs e)
        //{
        //    ChangeImage(btn9);
        //}

        public void RestartBtn(Button btn)
        {
            btn.Tag="?";
            btn.Image=Resources.question_mark_96;
            btn.BackColor=Color.Transparent;
        }
        public void RestartGame()
        {
            RestartBtn(btn1);
            RestartBtn(btn2);
            RestartBtn(btn3);
            RestartBtn(btn4);
            RestartBtn(btn5);
            RestartBtn(btn6);
            RestartBtn(btn7);
            RestartBtn(btn8);
            RestartBtn(btn9);


            lbPlayerTurn.Text="player 1";
            lbWinner.Text="in prograss";
            playerTurn=enPlayerTurn.player1;
            gameStats.playCount=0;
            gameStats.winner=enWinner.InProgress;
            gameStats.gameOver=false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

       

        
    }
}
