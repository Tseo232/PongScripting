using UnityEngine;


public class PlayerPaddle : Paddle
{
    private Vector2 _direction;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W))
        {
            _direction= Vector2.up; 
        }
        else if (Input.GetKey(KeyCode.DownArrow)|| Input.GetKey(KeyCode.S))
        {
            _direction= Vector2.down; 
        }
        else
        {
            _direction= Vector2.zero;
        }
    }
    void FixedUpdate()
    {
        if (_direction.sqrMagnitude !=0)
        {
            Rb.AddForce(_direction * this.Speed);
        }
    }
}
