using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Enemy : MonoBehaviour
    {
        public float timer = 1;
        private float timerTIME = 1;
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
            timerTIME -= Time.deltaTime;
            if (timerTIME <= 0)
            {
                timerTIME = timer;
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