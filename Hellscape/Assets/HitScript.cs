using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    [SerializeField]
    GameObject hitPic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Monster"))
        {
            Instantiate(hitPic, new Vector2(transform.position.x + 1f, transform.position.y), Quaternion.identity);
        }
    }
}
