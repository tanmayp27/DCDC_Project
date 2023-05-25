using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drone
{


    public class PropellerRotation : MonoBehaviour
    {
        [SerializeField] private float rpm=3400;
        private float motorKv;
        private float voltage;
        //private string compName="";
        //private int index=0;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            //index = ComponentList.indexSelected;
           // motorKv = (float)ComponentList.MotorList[index]["Kv Value"];
           // voltage = (float)ComponentList.BatteryList[0]["Voltage"];
           // rpm = motorKv * voltage;
            transform.RotateAround(transform.position, Vector3.up, Time.deltaTime * rpm);
        }
    }
}
