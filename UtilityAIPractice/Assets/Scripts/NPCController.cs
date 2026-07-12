using System;
using Unity.VisualScripting;
using UnityEngine;
using UtilityPractice.core;

namespace UtilityPractice.Core
{
    public class NPCController : MonoBehaviour
    {
        public MoveController mover { get; set; }
        public AIBrain aiBrain { get; set; }
        public Action[] actionsAvailable;

        private void Awake()
        {
            mover = GetComponent<MoveController>();
            aiBrain = GetComponent<AIBrain>();
            
        }
    }
}

