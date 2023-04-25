using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drone
{

    [RequireComponent(typeof(Rigidbody))]
    public class Base_Rigidbody : MonoBehaviour
    {

        [Header("Rigidbody Properties")]
        [SerializeField] private float weightInLbs = 1f;

        const float lbsToKg = 0.454f;
        protected float startDrag;
        protected float startAngularDrag;
        protected Rigidbody rb;
        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.mass = weightInLbs * lbsToKg;
                startDrag = rb.drag;
                startAngularDrag = rb.angularDrag;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (!rb)
            {
                return;
            }

            HandlePhysics();
        }

        protected virtual void HandlePhysics() { }
      
    }
}
