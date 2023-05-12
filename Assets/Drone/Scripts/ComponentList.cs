using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drone
{


    public class ComponentList : MonoBehaviour
    {
        public static List<Hashtable> MotorList = new List<Hashtable>();
        public static List<Hashtable> BatteryList = new List<Hashtable>();
        // Start is called before the first frame update
        void Start()
        {
            Hashtable Motor = new Hashtable();
            Motor["Name"] = "iFlight Xing Nano X1103 8000kv";
            Motor["Weight"] = 3.95f;
            Motor["Kv Value"] = 8000f;

            MotorList.Add(Motor);
            //more entries

            Hashtable Battery = new Hashtable();
            Battery["Voltage"] = 3.5f;
            Battery["Max Current"] = 3f;

            BatteryList.Add(Battery);
            //more entries
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}