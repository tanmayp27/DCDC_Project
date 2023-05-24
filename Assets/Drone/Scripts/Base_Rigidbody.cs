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
        private int index;
        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            
            if (rb)
            {
                
                startDrag = rb.drag;
                startAngularDrag = rb.angularDrag;
            }
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            index = ComponentList.indexSelected;
            if (!rb)
            {
                return;
            }

            weightInLbs = (float)ComponentList.MotorList[index]["Weight"] + (float)ComponentList.PropellerList[index]["Weight"];
            rb.mass = weightInLbs * lbsToKg;
            HandlePhysics();
        }

        protected virtual void HandlePhysics() { }
      
    }
}
