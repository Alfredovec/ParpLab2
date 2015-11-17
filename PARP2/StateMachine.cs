using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2
{
    public class StateMachine
    {
        private int _state;

        public StateMachine()
        {
            _state = 1;
        }

        public bool GetPrediction()
        {
            return _state > 2;
        }

        public void Depose(bool isJump)
        {
            if (isJump)
            {
                _state = _state == 4 ? _state + 1 : 4;
            }
            else
            {
                _state = _state == 0 ? _state - 1 : 0;
            }
        }
    }
}
