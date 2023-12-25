using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6_LIB
{
    public interface IATMState
    {
        bool Enter(ATMMAchine theMachine);
        string EnterDigit(ATMMAchine theMachine, char digit);
        void EraseDigits(ATMMAchine theMachine);
        void SetWorkMode(ATMMAchine theMachine, ATMMAchine.WorkMode workMode);
    }

    public abstract class State:IATMState
    {
        protected int maxDigits;
        protected System.Random ranNum = new System.Random(); 

        public virtual string EnterDigit(ATMMAchine theMachine, char digit)
        {
            if (theMachine.digitPosition < maxDigits)
            {
                theMachine.digitPad = "";
                theMachine.digitPadNumber += int.Parse("" + digit);

                for (int i = 0; i < maxDigits; i++)
                {
                    if (i < (maxDigits - 1) - theMachine.digitPosition)
                    {
                        theMachine.digitPad += '0';
                    }
                    else
                    {
                        theMachine.digitPad += theMachine.digitPadNumber;
                        break;
                    }
                }
                theMachine.digitPadNumber *= 10;
                theMachine.digitPosition++;
            }

            return theMachine.digitPad;
        }

        public virtual void EraseDigits(ATMMAchine theMachine)
        {
            theMachine.digitPad = "";
            theMachine.digitPadNumber = 0;

            for (int i = 0; i < maxDigits; i++)
                theMachine.digitPad += '0';

            theMachine.digitPosition = 0;
        }

        public abstract bool Enter(ATMMAchine theMachine);
        public abstract void SetWorkMode(ATMMAchine theMachine, ATMMAchine.WorkMode workMode);
    }

    public class UserAuthState:State
    {
        public UserAuthState(ATMMAchine theMachine)
        {
            this.maxDigits = 4;
            EraseDigits(theMachine);
            
        }

        string GetPIN(ATMMAchine theMachine)
        {
            return theMachine.digitPad;
        }

        public override bool Enter(ATMMAchine theMachine)
        {
            if (ranNum.Next(100) > theMachine.denyChance)
            {
                if (GetPIN(theMachine) == theMachine.PIN)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override void SetWorkMode(ATMMAchine theMachine, ATMMAchine.WorkMode workMode)
        {
            
        }
    }

    public class WaitingState : State
    {
        public WaitingState(ATMMAchine theMachine)
        {
            this.maxDigits = 7;
            EraseDigits(theMachine);
        }

        

        public override bool Enter(ATMMAchine theMachine)
        {
            if (ranNum.Next(100) > theMachine.denyChance)
            {
                int ammount = int.Parse(theMachine.digitPad);

                if (theMachine.workMode == ATMMAchine.WorkMode.cashIn)
                {
                    if (theMachine.usersCash >= ammount)
                    {
                        theMachine.balance += ammount;
                        theMachine.usersCash -= ammount;

                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
                else
                {
                    if (theMachine.balance >= ammount)
                    {

                        theMachine.balance -= ammount;
                        theMachine.usersCash += ammount;


                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public override void SetWorkMode(ATMMAchine theMachine, ATMMAchine.WorkMode workMode)
        {
            theMachine.workMode = workMode;
        }
    }

    public class ProcessingState : State
    {
        

        public override bool Enter(ATMMAchine theMachine)
        {
            return false;
        }

        public override string EnterDigit(ATMMAchine theMachine, char digit)
        {
            return "";
        }

        public override void EraseDigits(ATMMAchine theMachine)
        {
            
        }

        public override void SetWorkMode(ATMMAchine theMachine, ATMMAchine.WorkMode workMode)
        {
            
        }

    }

    public class LockedState : State
    {
        public LockedState(ATMMAchine theMachine)
        {
            this.maxDigits = 7;
            EraseDigits(theMachine);
            
        }

        public override bool Enter(ATMMAchine theMachine)
        {
            if (ranNum.Next(100) > theMachine.denyChance)
            {
                int ammount = int.Parse(theMachine.digitPad);

                if (theMachine.workMode == ATMMAchine.WorkMode.cashIn)
                {
                    if (theMachine.usersCash >= ammount)
                    {
                        theMachine.balance += ammount;
                        theMachine.usersCash -= ammount;

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override void SetWorkMode(ATMMAchine theMachine, ATMMAchine.WorkMode workMode)
        {
            theMachine.workMode = workMode;
        }
    }
}
