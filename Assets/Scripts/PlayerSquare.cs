using UnityEngine;

public class PlayerSquare : Square
{
    private Vector2 _direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.UpArrow)) //Adding extra key since I have stupid keyboard
        {
            _direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.F) || Input.GetKey(KeyCode.DownArrow)) //Adding extra key since I have stupid keyboard
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0) //Is moving in some direction
        {
            _rigidBody.AddForce(_direction * this.speed);
        }
    }
}
