using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector2 position = Vector2.zero;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            position.x += moveSpeed;
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            position.x -= moveSpeed;
        else
            position.x = 0.0f;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            position.y += moveSpeed;
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            position.y -= moveSpeed;
        else
            position.y = 0.0f;

        transform.position += new Vector3(position.x, position.y);
    }
}
