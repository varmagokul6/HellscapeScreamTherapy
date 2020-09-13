using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCombat : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Strike();
        }
    }

    void Strike()
    {
        // Play Attack Animation
        animator.SetTrigger("Strike");
;
    }
}
