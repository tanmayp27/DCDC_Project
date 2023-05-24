using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drone
{


    public class ComponentList : MonoBehaviour
    {
        public static List<Hashtable> MotorList = new List<Hashtable>();
        public static List<Hashtable> PropellerList = new List<Hashtable>();
        public static List<Hashtable> ESCList = new List<Hashtable>();
        public static List<Hashtable> BatteryList = new List<Hashtable>();

        public static int indexSelected;


        public void setIndex(int index)
        {
            indexSelected = index;
        }
        // Start is called before the first frame update
        void Start()
        {
            // Motors
            // 1
            Hashtable Motor = new Hashtable();
            Motor["Name"] = "iFlight Xing Nano X1103 8000kv";
            Motor["Weight"] = 3.95f;
            Motor["Kv Value"] = 8000f;

            MotorList.Add(Motor);

            // 2
            Motor = new Hashtable();
            Motor["Name"] = "EMAX Emax 1104 5250KV Babyhawk";
            Motor["Weight"] = 5.5f;
            Motor["Kv Value"] = 5250f;

            MotorList.Add(Motor);

            Motor = new Hashtable();
            Motor["Name"] = "DYS Fire FPV Race Edition 2600KV Brushless Outrunner Motor";
            Motor["Weight"] = 32f;
            Motor["Kv Value"] = 2600f;

            MotorList.Add(Motor);

            // 3 
            Motor = new Hashtable();
            Motor["Name"] = "DYS Fire FPV Race Edition 2600KV Brushless Outrunner Motor";
            Motor["Weight"] = 32f;
            Motor["Kv Value"] = 2600f;

            MotorList.Add(Motor);

            // 4 
            Motor = new Hashtable();
            Motor["Name"] = "MultiStar Elite 2306 2150KV CCW";
            Motor["Weight"] = 37.5f;
            Motor["Kv Value"] = 2150f;

            MotorList.Add(Motor);
            //more entries

            //Propellers
            // 1
            Hashtable Propeller = new Hashtable();
            Propeller["Name"] = "Gemfan Hulkie 1940x3";
            Propeller["Weight"] = 0.8f;
            Propeller["Pitch"] = 4f;

            PropellerList.Add(Propeller);

            // 2
            Propeller = new Hashtable();
            Propeller["Name"] = "Gemfan Hulkie 2036x4";
            Propeller["Weight"] = 0.84f;
            Propeller["Pitch"] = 3.6f;

            PropellerList.Add(Propeller);

            // 3
            Propeller = new Hashtable();
            Propeller["Name"] = "EMAX AVAN Blur 2inch 3blade";
            Propeller["Weight"] = 1.15f;
            Propeller["Pitch"] = 1.9f;

            PropellerList.Add(Propeller);

            // 4
            Propeller = new Hashtable();
            Propeller["Name"] = "KingKong 6040";
            Propeller["Weight"] = 3.38f;
            Propeller["Pitch"] = 4f;

            PropellerList.Add(Propeller);

            //ESCs
            // 1
            Hashtable ESC = new Hashtable();
            ESC["Name"] = "T-Motor F35A";
            ESC["Max Current"] = 35f;
            ESC["BEC Current"] = 45f;

            ESCList.Add(ESC);

            // 2
            ESC = new Hashtable();
            ESC["Name"] = "EMAX BLHeli 80A UBEC 5A 5V";
            ESC["Max Current"] = 80f;
            ESC["BEC Current"] = 5f;

            ESCList.Add(ESC);

            // 3
            ESC = new Hashtable();
            ESC["Name"] = "HobbyKing 30A ESC 3A UBEC";
            ESC["Max Current"] = 30f;
            ESC["BEC Current"] = 3f;

            ESCList.Add(ESC);

            //Battery
            // 1
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