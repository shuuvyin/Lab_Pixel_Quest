using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scrwipt : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Killbrik2";
    private SpriteRenderer spriteRenderer;

 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spriteRenderer.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spriteRenderer.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            spriteRenderer.color = Color.blue;
        }


        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(xInput * speed, rb.velocity.y);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;

                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }


    }
}
    



