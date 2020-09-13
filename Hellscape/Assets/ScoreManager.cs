using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    int score;
	int enemyHealth;
	
    public MicInput micObj;
	public HealthBar healthBar;
	
    void Start()
    {
        score = 0;
		enemyHealth = 10000;
    }

    // Update is called once per frame
    void Update()
    {
        Scoring();
        Debug.Log(score);
        finalScore();
    }


    public void Scoring(){
        float loudness = 20 * Mathf.Log10(Mathf.Abs(MicInput.MicFinal));
        if (loudness >= -200f && loudness <= -100f){
            score += 1;
			enemyHealth -= 1;
        }
        if (loudness >= -99f && loudness <= -70f){
            score += 3;
			enemyHealth -= 3;
        }
        if (loudness >= -69f && loudness <= -50f){
            score += 5;
			enemyHealth -= 5;
        }
        if (loudness >= -49f && loudness <= -30f){
            score += 10;
			enemyHealth -= 10;
        }
        if (loudness >= -29f && loudness <= -15f){
            score += 15;
			enemyHealth -= 15;
        }
        if (loudness >= -14f && loudness <= -5f){
            score += 20;
			enemyHealth -= 20;
        }
        if (loudness >= -4f && loudness <= 10f){
            score += 25;
			enemyHealth -= 25;
        }
        if (loudness < -200f && loudness > 10f)
        {
            score += 0;
			enemyHealth -= 0;
        }
		
		if (enemyHealth > 0){
			healthBar.SetHealth(enemyHealth);
		}
		else{
			healthBar.SetHealth(0);
			Debug.Log("You have defeated the monster!");
		}
		
    }
    public void finalScore(){
        if (!micObj.isInitialized){
            Debug.Log("Your Final Score: " + score.ToString());
        }
    }

}
