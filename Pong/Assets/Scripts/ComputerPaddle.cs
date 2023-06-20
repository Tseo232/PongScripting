
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    public void FixedUpdate()
    {
        if (ball.velocity. x> 0f)
        {
           if (ball.position.y>Rb.position.y)
           {
              Rb.AddForce(Vector2.up*Speed);
           }
        
         else if (ball.position.y<Rb.position.y)
         {
            Rb.AddForce(Vector2.down*Speed);
         }
   
        }
        else
        {
            if (Rb.position.y >0f)
            {
                Rb.AddForce(Vector2.down*Speed);
            }
            else if (Rb.position.y <0f)
            {
                Rb.AddForce(Vector2.up*Speed);
            }
        }
   
    }   
}
