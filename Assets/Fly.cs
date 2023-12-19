using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    public GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began){
            rb.velocity = Vector2.up * velocity;
        }
        
    }
    }

    public void OnCollisionEnter2D(Collision2D collision){
        gameManager.GameOver();
    }
}
