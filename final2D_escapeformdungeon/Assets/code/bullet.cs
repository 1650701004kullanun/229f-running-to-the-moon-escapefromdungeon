using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet : MonoBehaviour
{
    private GameObject player;

    private Rigidbody2D rb2d;

    public float force;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 dirrection = player.transform.position - transform.position;
        rb2d.velocity = new Vector2(dirrection.x, dirrection.y).normalized * force;

        float rot = Mathf.Atan2(-dirrection.y, -dirrection.x) * Mathf.Rad2Deg;
        transform.rotation = quaternion.Euler(0,0,rot);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
    }
}
