using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class MainGamePlay : MonoBehaviour
{
    [SerializeField] Text textElement;
    [SerializeField] States startState;
    [SerializeField] Text button1Text;
    [SerializeField] Text button2Text;
    [SerializeField] Text button3Text;
    States state;
    
    void Start()
    {
        state = startState;
        textElement.text = state.GetStateText();
        button1Text.text = state.GetButton1Text();
        button2Text.text = state.GetButton2Text();
        button3Text.text = state.GetButton3Text();


    }

    // Update is called once per frame
    void Update()
    {
        GameMain();
    }

    // Used to respond to user input
     void GameMain()
    {
        
       textElement.text = state.GetStateText();
       button1Text.text = state.GetButton1Text();
       button2Text.text = state.GetButton2Text();
       button3Text.text = state.GetButton3Text();
    }

   public void Button1Press()
    {
        States[] statesArray = state.GetOtherStates();
        state = statesArray[0];
    }

   public void Button2Press()
    {
        States[] statesArray = state.GetOtherStates();
        state = statesArray[1];
    }

    public void Button3Press()
    {
        States[] statesArray = state.GetOtherStates();
        state = statesArray[2];
    }

}