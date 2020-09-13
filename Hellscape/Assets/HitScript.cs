using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour
{
    [SerializeField]
    GameObject hitPic;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Monster"))
        {
            Instantiate(hitPic, new Vector2(transform.position.x + 1f, transform.position.y), Quaternion.identity);
        }
    }
}
