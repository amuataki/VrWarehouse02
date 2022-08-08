using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class addbuttonclass : MonoBehaviour
{
    public TMPro.TMP_InputField LeftInput;
    public TMPro.TMP_InputField RightInput;
    public TMPro.TMP_Text Answertext;
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void add()
    {
        Debug.Log("Hey Let's Add");
        Debug.Log("Go");
       
        int LeftNew = int.Parse(LeftInput.text);

        int RightNew = int.Parse(RightInput.text);
        
        int sum;
        sum = LeftNew + RightNew;
        Debug.Log(sum);
        
         Answertext.text = sum.ToString();
       




    }
}
//get text
//declare as int 
//add new values
//debuglog addition
