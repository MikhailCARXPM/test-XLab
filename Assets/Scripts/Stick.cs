using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace Golf
{
    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> OnCollision;

        private void OnCollisionEnter(Collision collision)
        {
            OnCollision.Invoke(collision.collider);
        }
    }

}