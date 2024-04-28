using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincollect : MonoBehaviour
{
    public int coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Coin collected");
            cointcount.coin += 1;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
