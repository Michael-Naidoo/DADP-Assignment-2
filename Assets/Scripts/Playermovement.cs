using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public bool isMoving;
    public bool up;
    public bool down;
    public bool left;
    public bool right;
    public float speed = 10;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            isMoving = true;
            up = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            isMoving = true;
            left = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            isMoving = true;
            down = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            isMoving = true;
            right = true;
        }

        var trueSpeed = speed * Time.deltaTime;
        var position = player.transform.position;
        if (isMoving && up)
        {
            position = new Vector3(position.x, position.y + trueSpeed, position.z);
            player.transform.position = position;
        }
        else if (isMoving && down)
        {
            player.transform.position = new Vector3(position.x,position.y - trueSpeed, position.z);
        }
        else if (isMoving && left)
        {
            player.transform.position = new Vector3(position.x - trueSpeed,position.y, position.z);
        }
        else if (isMoving && right)
        {
            player.transform.position = new Vector3(position.x + trueSpeed,position.y - trueSpeed, position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col);
        if (col.gameObject.CompareTag("Wall"))
        {
            isMoving = false;
            up = false;
            down = false;
            left = false;
            right = false;
        }
    }
}
