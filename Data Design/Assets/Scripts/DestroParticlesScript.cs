using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroParticlesScript : MonoBehaviour
{
    public float delay = 0.3f;
    public GameObject shrapnelEffect1;

    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerOne"))
        {
            Instantiate(shrapnelEffect1, transform.position, Quaternion.identity);
           
        }
    }
}
