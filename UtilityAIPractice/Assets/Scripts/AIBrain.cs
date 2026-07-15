using System;
using UnityEngine;

namespace UtilityPractice.Core
{
    public class AIBrain : MonoBehaviour
    {
        public Action bestAction;
        private NPCController _npcController;
        
        private void Awake()
        {
            _npcController = GetComponent<NPCController>();
        }

        private void DecideBestAction(Action[] actionsAvailable)
        {
            float score = 0f;
            int nextBestActionIndex = 0;

            for (int i = 0; i < actionsAvailable.Length; i++)
            {
                if (ScoreAction(actionsAvailable[i]) > score)
                {
                    nextBestActionIndex = i;
                    score = actionsAvailable[i].score;
                }
            }

            bestAction = actionsAvailable[nextBestActionIndex];
        }

        private float ScoreAction(Action action)
        {
            float score = 1f;

            for (int i = 0; i < action.consideration.Length; i++)
            {
                float considerationScore = action.consideration[i].ScoreConsideration();
                score *= considerationScore;

                if (score == 0)
                {
                    action.score = 0;
                    return action.score;
                }
            }

            float originalScoe = score;
            float modFactor = 1 - (1 / action.consideration.Length);
            float makeupValue = (1 - originalScoe) * modFactor;
            action.score = originalScoe + (originalScoe * makeupValue);

            return action.score;
        }
    }
}

