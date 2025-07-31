using UnityEngine;

public class Square : MonoBehaviour
{
    protected Rigidbody2D _rigidBody;
    public float speed = 8.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPostion()
    {
        _rigidBody.position = new Vector2(_rigidBody.position.x, 0.0f);
        _rigidBody.linearVelocity = Vector2.zero;
    }
}
