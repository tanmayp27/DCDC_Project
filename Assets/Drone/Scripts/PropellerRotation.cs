using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drone
{


    public class PropellerRotation : MonoBehaviour
    {
        [SerializeField] private float rpm=3400f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {
               

            transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * rpm);
        }
    }
}
