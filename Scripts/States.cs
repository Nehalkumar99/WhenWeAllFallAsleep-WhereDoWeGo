using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "States")]
public class States : ScriptableObject
{
    [SerializeField] string gameText;
    [SerializeField] string button1String;
    [SerializeField] string button2String;
    [SerializeField] string button3String;
    [SerializeField] States[] otherStates;
     // Start is called before the first frame update
    public string GetStateText()
    {
        return gameText;
      
    }

    public string GetButton1Text()
    {
        return button1String;
    }
   
    public string GetButton2Text()
    {
        return button2String;
    }
    public string GetButton3Text()
    {
        return button3String;
    }
    public States[] GetOtherStates()
    {
        return otherStates;
    }
   
}
