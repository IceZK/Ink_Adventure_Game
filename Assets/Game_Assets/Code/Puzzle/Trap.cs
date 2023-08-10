using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    public class Trap : MonoBehaviour
    {
        // Start is called before the first frame update
        public int Damage = 10;
        public Character_Status Char_Stat;
        public SpriteRenderer sr;
        private float timeAnimate = 2;
        void Start()
        {
            sr = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            timeAnimate -= Time.deltaTime;
            if (timeAnimate <= 0)
            {
                sr.color = new Color(255, 255, 255, 255);
            }    
        }
        void DoDamage()
        {
            Char_Stat.CurrentInk -= Damage;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Trap")
            {
                sr.color = new Color(255, 0, 0, 255);
                timeAnimate = 2;
                DoDamage();
                Destroy(other.gameObject, 0);
            }
        }

    }
}

