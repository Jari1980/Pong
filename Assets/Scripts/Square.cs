using UnityEngine;

public class Square : MonoBehaviour
{
    protected Rigidbody2D _rigidBody;
    public float speed = 8.0f;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }
}
