using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private float destroyDelay = 0.3f;
    private bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Biscuit" && !hasPackage)
        {
            Debug.Log("Biscuit picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }
        else if (other.tag == "Doggo" && hasPackage)
        {
            Debug.Log("Biscuit delivered!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}

