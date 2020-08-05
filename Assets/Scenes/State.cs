using System.Collections.Generic;
using UnityEngine;

namespace Scenes
{
    [CreateAssetMenu(menuName = "StateScript")]
    public class State : ScriptableObject
    {
        [TextArea(10,14)][SerializeField] private string[] storyText;

        [SerializeField] private State[] nextStates;

        public string GetStateStory()
        {
            return storyText[0];
        }
            
        public State[] GetStatesArray()
        {
            return nextStates;
        }
            
    }
}