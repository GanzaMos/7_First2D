using UnityEngine;

namespace Scenes
{
    [CreateAssetMenu(menuName = "StateScript")]
    public class State : ScriptableObject
    {
        [TextArea(10,14)][SerializeField] private string storyText;
    }
}