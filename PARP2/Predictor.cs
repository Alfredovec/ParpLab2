using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARP2
{
    public class Predictor
    {
        private static StateMachine[] stateMachines;

        private static Dictionary<string, StateMachine> stateMachinesDictionary;

        static Predictor()
        {
            stateMachines = new StateMachine[4] { new StateMachine(), new StateMachine(), new StateMachine(), new StateMachine() };
            stateMachinesDictionary = new Dictionary<string, StateMachine>()
            {
                { "00", stateMachines[0] },
                { "01", stateMachines[1] },
                { "10", stateMachines[2] },
                { "11", stateMachines[3] }
            };
        }

        public static string Predict(int[] numbers)
        {
            string result = string.Empty;

            for (var i = 0; i < numbers.Length; i++)
            {
                int[] previous = new int[2];
                previous[0] = i - 2 >= 0 ? numbers[i - 2] : 0;
                previous[1] = i - 1 >= 0 ? numbers[i - 1] : 0;

                StateMachine currentMachine = stateMachinesDictionary[string.Join("", previous)];
                bool isJumpPredicted = currentMachine.GetPrediction();
                bool isJump = numbers[i] != 0;
                currentMachine.Depose(isJump);

                result += isJump == isJumpPredicted ? "0" : "E";
            }

            return result;
        }
    }
}
