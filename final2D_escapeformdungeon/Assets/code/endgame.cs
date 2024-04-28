using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{
    public GameObject playerPoint,startPoint;
    public Rigidbody2D rb2d;
    void OnTriggerEnter2D(Collider2D aaa)
    {
        if (aaa.gameObject.CompareTag("Player"))
        {
            //playerPoint.transform.position = startPoint.transform.position;
            SceneManager.LoadScene(4);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
