using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drone
{


    public class PropellerRotation : MonoBehaviour
    {
        [SerializeField] private float rpm;
        private float motorKv;
        private float voltage;
        private string compName="";
        private int index;
        // Start is called before the first frame update
        void Start()
        {
            motorKv = (float) ComponentList.MotorList[0]["Kv Value"];
            voltage = (float)ComponentList.BatteryList[0]["Voltage"];
            rpm = motorKv * voltage;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            

            transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * rpm);
        }
    }
}
