using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenToMic : MonoBehaviour
{
    public MicInput micObject;
    public Timer timerObject;

    int n; 
    // Start is called before the first frame update
    
    void Start()
    {
        n = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float loudness = 20 * Mathf.Log10(Mathf.Abs(MicInput.MicFinal));
        Debug.Log("In decibels: " + loudness.ToString("##-####"));
        
        if (timerObject.timeFlag == false){
            micObject.StopMicrophone();
        }
    }


}
