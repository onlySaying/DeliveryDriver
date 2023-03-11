using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float stilspeed = 160f;
    [SerializeField]float movespeed = 20f;
    [SerializeField]float slowSpeed = 13f;
    [SerializeField]float boostSpeed = 24f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steeramonunt = Input.GetAxis("Horizontal")*-stilspeed * Time.deltaTime;
        float moveAmount = movespeed*Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0,0,steeramonunt);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
         if (other.tag == "SpeedUp")   
        {
            movespeed = boostSpeed;
        }
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        movespeed = slowSpeed;
    }
}
