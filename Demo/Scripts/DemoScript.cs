using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SimpleMan.Extensions
{
    public class DemoScript : MonoBehaviour
    {
        public bool isPressed = false;


        private void Start()
        {
            //Wait until is pressed will be true
            //then invoke OnDone
            this.WaitUntil(() => isPressed, OnDone);
        }


        private void OnDone()
        {
            print("OperationDone!");
        }
    }
}
