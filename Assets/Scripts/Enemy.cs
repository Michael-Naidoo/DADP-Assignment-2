using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        private float timer = 5;
        public GameObject projectile;
        public enum projectileDirection
        {
            up,
            down,
            left,
            right,
        }

        public projectileDirection direction;
        
        private void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = 10;
                var go = Instantiate(projectile, transform.position, Quaternion.identity);
                Instantiate(go);
                if (direction == projectileDirection.down)
                {
                    go.GetComponent<Projectile>().direction = "down";
                }
                else if (direction == projectileDirection.up)
                {
                    go.GetComponent<Projectile>().direction = "up";
                }
                else if (direction == projectileDirection.left)
                {
                    go.GetComponent<Projectile>().direction = "left";
                }
                else if (direction == projectileDirection.right)
                {
                    go.GetComponent<Projectile>().direction = "right";
                }
            }
        }
    }
}