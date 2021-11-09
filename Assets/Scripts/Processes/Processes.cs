using UnityEngine;
using parking_game.Assets.Scripts.Processes.Objects;
using parking_game.Assets.Scripts.Processes.Interface;
namespace parking_game.Assets.Scripts.Processes
{
    public static class Processes
    {
        public static void startEvent(GameObject character,ProcessConstant constant)
        {
            switch(constant)
            {
                case(ProcessConstant.GO):
                    (new GoProcess(character) as IProcess).ProcessEvent();
                    break;
                case(ProcessConstant.BACK):
                    (new BackProcess(character) as IProcess).ProcessEvent();
                    break;
            }
        }
    }
}