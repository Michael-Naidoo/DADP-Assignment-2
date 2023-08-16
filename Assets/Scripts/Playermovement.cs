using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public bool isMoving;
    public bool up;
    public bool down;
    public bool left;
    public bool right;
    public float speed = 10;
    public GameObject wallPiece;
    public GameObject pos;
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
            player.transform.position = new Vector3(position.x,position.y + trueSpeed, position.z);
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
            player.transform.position = new Vector3(position.x + trueSpeed,position.y, position.z);
        }


        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            isMoving = false;
            up = false;
            down = false;
            left = false;
            right = false;
        }
        else if (col.gameObject.CompareTag("ObsWall") || col.gameObject.CompareTag("Enemy") || col.gameObject.CompareTag("Projectile") || col.gameObject.CompareTag("PitFall"))
        {
            isMoving = false;
            up = false;
            down = false;
            left = false;
            right = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<WallPiece>())
        {
            Debug.Log("no im fine");
            Instantiate(wallPiece, pos.transform.position, Quaternion.identity);
            col.gameObject.SetActive(false);
            // add vert to the next pos in the game object array for positions of the wall pieces
            // to do this i need a prefab i can clone
        }
        else if (col.gameObject.CompareTag("Finish"))
        {
            if (SceneManager.GetActiveScene().name == "Level 1")
            {
                SceneManager.LoadScene("Level 2");
            }
            else if (SceneManager.GetActiveScene().name == "Level 2")
            {
                SceneManager.LoadScene("Level 3");
            }
            else if (SceneManager.GetActiveScene().name == "Level 3")
            {
                SceneManager.LoadScene("Level 4");
            }
            else if (SceneManager.GetActiveScene().name == "Level 4")
            {
                SceneManager.LoadScene("Level 2");
            }
        }
    }
    // exit script
}
