using AIS_LAB6_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AIS_LAB6
{
    public partial class Form1 : Form
    {
        ATMMAchine ATM = new ATMMAchine("4457", 120000, 20);
        ATMMAchine.WorkState pastState=ATMMAchine.WorkState.Auth;

        SoundPlayer soundPlayer;

        int cash = 500;
        int k = 0;
        bool result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void EnterDigit(object sender, EventArgs e)
        {
            Button keyPadButton = sender as Button;

            if (keyPadButton.Text == "V")
            {
                StartProcessing();   
            }
            else if (keyPadButton.Text=="X")
            {
                ATM.EraseDigits();
            }
            else
            {
                char digit = keyPadButton.Text.ToCharArray()[0];

                ATM.EnterDigit(digit);
            }

            DoSound();
            digitPadLabel.Text = ATM.digitPad;
        }

        void StartProcessing()
        {
            pastState = ATM.workState;
            result =ATM.Enter();
            
            ATM.SetState(ATMMAchine.WorkState.Processing);

            processingTimer.Start();
            waitTimer.Start();
        }

        void StopProcessing()
        {
            processingTimer.Stop();
            waitTimer.Stop();

            switch (pastState)
            {
                case
                    ATMMAchine.WorkState.Auth:
                    {
                        if (result)
                        {
                            StartService();
                        }
                        else
                        {
                            StartAuth();
                        }
                    }
                    break;
                case
                    ATMMAchine.WorkState.Waiting:
                    {
                        if (ATM.balance==0)
                        {
                            StartLock();
                        }
                        else
                        {
                            StartService();
                        }
                    }break;
                case
                    ATMMAchine.WorkState.Locked:
                    {
                        if (ATM.balance == 0)
                        {
                            StartLock();
                        }
                        else
                        {
                            StartService();
                        }
                    }
                    break;
            }

            UpdateUserCashLabel();
        }

        void StartLock()
        {
            ATM.SetState(ATMMAchine.WorkState.Locked);

            SwitchWorkMode(ATMMAchine.WorkMode.cashIn);

            label2.Text = "В банкомате закончились средства";
            digitPadLabel.Text = ATM.digitPad;
        }

        void StartAuth()
        {
            ATM.SetState(ATMMAchine.WorkState.Auth);
            pastState = ATMMAchine.WorkState.Auth;

            label2.Text = "Введите PIN";
            digitPadLabel.Text = ATM.digitPad;
        }
        void StartService()
        {
            ATM.SetState(ATMMAchine.WorkState.Waiting);

            SwitchWorkMode(ATMMAchine.WorkMode.cashIn);

            digitPadLabel.Text = ATM.digitPad;
        }

        void SwitchWorkMode(ATMMAchine.WorkMode workMode)
        {
            if (workMode == ATMMAchine.WorkMode.cashIn)    
                label2.Text = "Введите сумму внесения";
            else
                label2.Text = "Введите сумму снятия";


            ATM.SetWorkMode(workMode);      
        }

        void UpdateUserCashLabel()
        {
            cashLabel.Text = $"Наличные: {ATM.usersCash} р.";
        }
        private void processingTimer_Tick(object sender, EventArgs e)
        {
            label2.Text = "Пожалуйста подождите";

            if (k == 0)
                digitPadLabel.Text = "";
            else if (k == 2)
                k = -1;

            digitPadLabel.Text += ".";
            k++;
        }

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            StopProcessing();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SwitchWorkMode(ATMMAchine.WorkMode.cashIn);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SwitchWorkMode(ATMMAchine.WorkMode.cashOut);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            StartAuth();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            soundPlayer=new SoundPlayer();

            string soundFileName = "press.wav";
            string soundFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, soundFileName);

            soundPlayer.SoundLocation = soundFilePath;
            


        }

        void DoSound()
        {
            soundPlayer.Play();
        }
    }
}
