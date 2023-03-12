using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL4_1302210014
{
    internal class DoorMachine
    {
        public enum DoorState
        {
            TERKUNCI,
            TERBUKA
        }
        public enum Trigger
        {
            BUKAPINTU,
            KUNCIPINTU
        }

        class Transition
        {
            public DoorState prevState;
            public DoorState nextState;
            public Trigger trigger;

            public Transition(DoorState prevState, DoorState nextState, Trigger trigger)
            {
                this.prevState = prevState;
                this.nextState = nextState;
                this.trigger = trigger;
            }
        }

        Transition[] transitions =
        {
            new Transition(DoorState.TERBUKA, DoorState.TERKUNCI, Trigger.KUNCIPINTU),
            new Transition(DoorState.TERKUNCI, DoorState.TERBUKA, Trigger.BUKAPINTU),
            new Transition(DoorState.TERKUNCI, DoorState.TERKUNCI, Trigger.KUNCIPINTU),
            new Transition(DoorState.TERBUKA, DoorState.TERBUKA, Trigger.BUKAPINTU)
        };

        public DoorState currentState = DoorState.TERKUNCI;

        public DoorState getNextState(DoorState prevState, Trigger trigger)
        {
            DoorState nextState = prevState;
            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].prevState == prevState && transitions[i].trigger == trigger)
                {
                    nextState = transitions[i].nextState; break;
                }
            }
            return nextState;
        }

        public void activateTrigger(Trigger trigger)
        {
            DoorState nextState = getNextState(currentState, trigger);
            currentState = nextState;
            if (currentState == DoorState.TERKUNCI)
            {
                Console.WriteLine("Pintu terkunci");
            } else if (currentState == DoorState.TERBUKA)
            {
                Console.WriteLine("Pintu tidak terkunci");
            }
        }
    }
}
