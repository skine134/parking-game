using UnityEngine;

namespace parking_game.Assets.Scripts.Processes.Objects
{
    public class GoProcess:BaseProcess
    {
        public GoProcess(GameObject character):base(character){}
        public override void ProcessEvent()
        {
            character.transform.position += new Vector3(10f,0f,0f);
        }
    }
}