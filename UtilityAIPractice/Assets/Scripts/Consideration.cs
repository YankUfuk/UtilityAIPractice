using System;
using UnityEngine;

namespace UtilityPractice.Core
{
    public abstract class Consideration : MonoBehaviour
    {
        public string name;
        private float _score;

        public float score
        {
            get => _score;
            set => _score = value;
        }

        public virtual void Awake()
        {
            score = 0;
        }

        public abstract void ScoreConsideration();
    }
}

