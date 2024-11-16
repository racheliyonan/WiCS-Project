using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int amt_movement = 2;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            // Implement collision response here, e.g., 
            Debug.Log("Player collided with obstacle");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
             {
                Vector3 position = this.transform.position;
                position.x-=amt_movement;
                this.transform.position = position;
                }
        if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Vector3 position = this.transform.position;
                position.x+=amt_movement;
                this.transform.position = position;
            }
        if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Vector3 position = this.transform.position;
                position.y+=amt_movement;
                this.transform.position = position;
            }
        if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Vector3 position = this.transform.position;
                position.y-=amt_movement;
                this.transform.position = position;
            }
    }
}
