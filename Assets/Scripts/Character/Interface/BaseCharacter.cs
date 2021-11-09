using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using parking_game.Assets.Scripts.Processes;

namespace parking_game.Assets.Scripts.Character.Interface
{
    public abstract class BaseCharacter:MonoBehaviour
    {
        [SerializeField]
        public List<ProcessConstant> processList;
    }
}