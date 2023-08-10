using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace IceZK_DEV
{
    public class Fill_Ink : MonoBehaviour
    {
        public int ink_need;
        public TextMeshPro text;
        public Image image;
        public GameObject UIMenu;
        public bool MenuActive;
        public bool finish;

        public Character_Status character_Status;


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        void puzzle()
        {
            if (Input.GetKey("interact") && MenuActive && character_Status.CurrentInk >= ink_need)
            {
                character_Status.CurrentInk -= ink_need;
                finish = true;
            }
            
        }
        private void OnTriggerEnter(Collider other)
        {
            if(!finish)
            {
                UIMenu.SetActive(true);
                MenuActive = true;
            }
            
           
        }
        private void OnTriggerStay(Collider other)
        {
            puzzle();
            if (finish)
            {
                //action
                
            }
        }
        private void OnTriggerExit(Collider other)
        {
            UIMenu.SetActive(false);
            MenuActive = false;
        }

    }
}

