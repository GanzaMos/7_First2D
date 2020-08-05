using System.Collections;
using System.Collections.Generic;
using Scenes;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] private Text storyText;
    [SerializeField] private State currentState;

    private State state;
    
    void Start()
    {
        state = currentState;
        storyText.text = state.GetStateStory();
    }
    
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetStatesArray();
        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1+i))
            {
                state = nextStates[i];
            }
        }
        storyText.text = state.GetStateStory();
    }
}
