using UnityEngine;

public class Paddle : MonoBehaviour
{ protected Rigidbody2D Rb;
  public float Speed;
     private void Awake()
     {
        Rb = GetComponent<Rigidbody2D>();
     }
}
