using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Projectile : MonoBehaviour
    {
        public string direction;
        public float speed = 5;

        private void Update()
        {
            var trueSpeed = speed * Time.deltaTime;
            var position = transform.position;
            if (direction == "up")
            {
                transform.position = new Vector3(position.x,position.y + trueSpeed, position.z);
            }
            else if (direction == "down")
            {
                transform.position = new Vector3(position.x,position.y - trueSpeed, position.z);
            }
            else if (direction == "left")
            {
                transform.position = new Vector3(position.x - trueSpeed,position.y, position.z);
            }
            else if (direction == "right")
            {
                transform.position = new Vector3(position.x + trueSpeed,position.y, position.z);
            }
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
            Debug.Log(col.gameObject.name);
            Destroy(gameObject);
        }
    }
}