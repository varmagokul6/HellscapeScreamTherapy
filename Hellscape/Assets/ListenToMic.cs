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
        checkDecibel();
        
        checkTimeFlag();
        
    }

    public void checkDecibel(){
        if (timerObject.timeFlag == true){
            float loudness = 20 * Mathf.Log10(Mathf.Abs(MicInput.MicFinal));
            Debug.Log("In decibels: " + loudness.ToString("##-####"));
        }
        else{
            micObject.StopMicrophone();
        }
    }

    public void checkTimeFlag(){
        if (timerObject.timeFlag == false){
            micObject.StopMicrophone();
        }
    }


}
