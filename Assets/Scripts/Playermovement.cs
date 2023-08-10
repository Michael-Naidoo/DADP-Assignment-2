using System;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField] private bool isMoving = false;
    [SerializeField] private bool up = false;
    [SerializeField] private bool down = false;
    [SerializeField] private bool left = false;
    [SerializeField] private bool right = false;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject obsWall;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject wallPickUp;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject projectile;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && isMoving == false)
        {
            isMoving = true;
            up = true;
        }
        else if (Input.GetKey(KeyCode.A) && isMoving == false)
        {
            isMoving = true;
            left = true;
        }
        else if (Input.GetKey(KeyCode.S) && isMoving == false)
        {        
            isMoving = true;
            down = true;
        }
        else if (Input.GetKey(KeyCode.D) && isMoving == false)
        {
            isMoving = true;
            right = true;
        }
        while (isMoving && up)
        {
            player.transform.Translate(Vector3.up);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag(""))
        {
            
        }
    }
}
