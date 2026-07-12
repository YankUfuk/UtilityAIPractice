using System;
using UnityEngine;

namespace UtilityPractice.Core
{
    public class AIBrain : MonoBehaviour
    {
        public Action[] actions;
        private NPCController _npcController;
        
        private void Awake()
        {
            _npcController = GetComponent<NPCController>();
        }

        private void DecideBestAction(Action[] actionsAvailable)
        {
            
        }

        private void Score(Action action)
        {
            
        }
    }
}

