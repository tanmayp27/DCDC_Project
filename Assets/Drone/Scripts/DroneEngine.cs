using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drone
{

    [RequireComponent(typeof(BoxCollider))]

    public class DroneEngine : MonoBehaviour, IEngine
    {
        protected float inFlight = 1f;

        private int index = 0;

        [Header("Engine Properties")]
        [SerializeField] private float maxPower = 4f;

        void FixedUpdate()
        {
            index = ComponentList.indexSelected;
            if (maxPower == 0f)
            {
                inFlight = 0f;
            }
            else inFlight = 1f;

            maxPower = ((float)ComponentList.MotorList[index]["Kv Value"]) * ((float)ComponentList.ESCList[index]["BEC Current"]) / 2000f;
        }

        public void InitEngine()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEngine(Rigidbody rb, InputScript input)
        {
            
            //Debug.Log("Running Engine: " + gameObject.name);
            Vector3 engineForce = Vector3.zero;
            

            engineForce = inFlight* (transform.up * ((rb.mass * Physics.gravity.magnitude) + (input.Throttle * maxPower))) / 4f;  //4 is engine count. Must adapt incase of less engines. 
            rb.AddForce(engineForce, ForceMode.Force);
        }

        
    }
}
