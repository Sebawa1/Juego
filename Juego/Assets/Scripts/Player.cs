// hace que el jugador se mueva constantemente hacia la derecha

using UnityEngine;

public class Player : MonoBehaviour{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate(){
        rb.velocity = Vector2.right * speed;
    }
}