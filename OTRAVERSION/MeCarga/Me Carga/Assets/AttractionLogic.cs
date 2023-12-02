using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class AttractionLogic : MonoBehaviour
{
    public int carga;


    public Sprite positivo;
    public Sprite negativo;
    public SpriteRenderer electron;
    

    public float radius = 5f;
    public float maximaAtraccion = 10f;
    public float maximaRepulsion = 10f;
    public LayerMask layerMask;
    // Start is called before the first frame update
    private void Start()
    {
        ChangeSprite();
    }

    void FixedUpdate()
    {
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, radius, layerMask);
        foreach (var hitCollider in hitColliders)
        {
            Rigidbody2D rb = hitCollider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Debug.Log(hitCollider.gameObject.tag);
                Vector2 direction = (Vector2)transform.position - rb.position;
                float distance = direction.magnitude;
                float normalizedDistance = Mathf.Clamp(distance / radius, 0.1f, 1f); // Avoid division by zero
                
                float forceMagnitude = ShouldBeAttracted(hitCollider.gameObject)
                    ? carga*maximaAtraccion / (normalizedDistance * normalizedDistance)
                    : -carga*maximaRepulsion / (normalizedDistance * normalizedDistance);
                
                rb.AddForce(direction.normalized * forceMagnitude);
            }
        }
    }
    
    bool ShouldBeAttracted(GameObject obj)
    {
        // Example: Use tag to determine behavior
        return obj.tag == "Negativo";
    }

    public void ChangeSprite()
    {
        if (carga > 0)
        {
            electron.sprite = positivo;
        }
        else
        {
            electron.sprite = negativo;
        }
    }

}
