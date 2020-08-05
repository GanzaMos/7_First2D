using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] private Text storyText;
    
    void Start()
    {
        storyText.text = ("First programm text");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
