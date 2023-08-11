using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

namespace IceZK_DEV
{
    public class Player_HealthBar : MonoBehaviour
    {

        public Image fill;
        public int currentHealth;
        public int MaxHealth;
       

        // Use this for initialization
        void Start()
        {
           
            fill.fillAmount = 1;
            currentHealth = MaxHealth;
            
            
        }
        
        void Add(int i)
        {
            currentHealth += i;
            fill.fillAmount = (float)currentHealth / MaxHealth;
        }
        public void Dedect(int i) 
        {
            currentHealth -= i;
            if(currentHealth < 0)
            {
                currentHealth = 0;
            }
            fill.fillAmount = (float)currentHealth / MaxHealth;

        }
    }
}