using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    public Slider slider;
	
	public void SetHealth(float health){
		Debug.Log("Slider: " + health.ToString());
		slider.value = 1000 * health/50000;
	}
}
