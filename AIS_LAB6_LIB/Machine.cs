using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6_LIB
{
    public class ATMMAchine
    {
        State machineState;
        public WorkMode workMode;
        public WorkState workState;

        public int usersCash=500;
        public string PIN;
        public string digitPad="0000";
        public int digitPadNumber = 0;
        public int digitPosition=0;
        public int balance;
        public int denyChance;


        public ATMMAchine(string PIN, int balance, int denyChance) 
        {
            this.PIN = PIN;
            this.balance = balance;
            this.denyChance = denyChance;
            SetState(WorkState.Auth);          
        }

        public enum WorkMode
        {
            cashIn,
            cashOut
        }

        public enum WorkState
        {
            Auth,
            Waiting,
            Processing,
            Locked
        }

        public void SetWorkMode(WorkMode workMode)
        {
            machineState.SetWorkMode(this, workMode);
        }

        public void SetState(WorkState newState)
        {
            switch (newState)
            {
                case WorkState.Auth:
                    {
                        machineState=new UserAuthState(this);                   
                    }break;
                case WorkState.Waiting:
                    {
                        machineState = new WaitingState(this);
                    }break;
                case WorkState.Processing:
                    {
                        machineState = new ProcessingState();
                    }break;
                case WorkState.Locked:
                    {
                        machineState=new LockedState(this);
                    }break;
            }

            workState = newState;
        }

        public void EnterDigit(char digit)
        {
            digitPad=machineState.EnterDigit(this, digit);
        }

        public void EraseDigits()
        {
            machineState.EraseDigits(this);
        }

        public bool Enter()
        {
            return machineState.Enter(this);
        }
    }
}
