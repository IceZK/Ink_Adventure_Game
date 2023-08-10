using IceZK_DEV;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using TMPro;
namespace Kagerou
{
    public class CombatUI : MonoBehaviour
    {
        public TMP_Text player_status;
        public TMP_Text game_status;
        public TMP_Text enemy_status;

        private float player_baseMaxInk;
        private float player_baseInk;
        private float player_baseDamage;
        private float enemy_baseMaxInk;
        private float enemy_baseInk;
        private float enemy_baseDamage;
        // Start is called before the first frame update
        void Start()
        {

            player_baseMaxInk = Character_Status_Manager.player_baseMaxInk;
            player_baseInk = Character_Status_Manager.player_baseInk;
            player_baseDamage = Character_Status_Manager.player_baseDamage;
            enemy_baseMaxInk = Character_Status_Manager.enemy_baseMaxInk;
            enemy_baseInk = Character_Status_Manager.enemy_baseInk;
            enemy_baseDamage = Character_Status_Manager.enemy_baseDamage;           
        }

        // Update is called once per frame
        void Update()
        {
            player_status.text = "HP: " + player_baseInk + " / " + player_baseMaxInk + "\n Atk: " + player_baseDamage;
            game_status.text = FightingSystem.phase_text;
            enemy_status.text = "HP: " + enemy_baseInk + " / " + enemy_baseMaxInk + "\n Atk: " + enemy_baseDamage;
        }
    }
}

