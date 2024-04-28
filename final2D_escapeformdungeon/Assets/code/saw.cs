using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saw : MonoBehaviour
{
    public GameObject playerPoint,startPoint;
    void OnTriggerEnter2D(Collider2D aaa)
    {
        if (aaa.gameObject.CompareTag("Player"))
        {
            playerPoint.transform.position = startPoint.transform.position;
            SceneManager.LoadScene(3);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
