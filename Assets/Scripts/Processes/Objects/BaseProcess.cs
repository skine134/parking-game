using parking_game.Assets.Scripts.Processes.Interface;
using UnityEngine;

namespace parking_game.Assets.Scripts.Processes.Objects
{
    public abstract class BaseProcess : IProcess
    {
        protected GameObject character;
        public BaseProcess(GameObject character)
        {
            this.character = character;
        }
        public abstract void ProcessEvent();
    }
}