using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]Color32 hasPackageColor = new Color32(230,100,230,255);
    [SerializeField]Color32 noPackageColor = new Color32(255,255,255,255);
    [SerializeField]float destroyTime = 0.5f;
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("qouch");
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" && hasPackage == false)   
        {
            hasPackage = true;
            Debug.Log("package picked up");
            Destroy(other.gameObject, destroyTime);
            spriteRenderer.color = hasPackageColor;
        }
        if (other.tag == "Customer" && hasPackage == true)   
        {
            hasPackage = false;
            Debug.Log("package Deliverd");
            spriteRenderer.color = noPackageColor;
        }
    }
}
