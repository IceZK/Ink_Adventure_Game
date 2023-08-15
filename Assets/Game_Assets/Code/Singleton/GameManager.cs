using IceZK_DEV;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Game_Assets.Code.Singleton
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager GM_instance;

        public static int day;
        public static int curse;

        private void Awake()
        {
            // if the singleton hasn't been initialized yet
            if (GM_instance != null && GM_instance != this)
            {
                Destroy(this.gameObject);

            }
            else
            {
                DontDestroyOnLoad(this.gameObject);
                GM_instance = this;


            }
        }

        //เพิ่มcurse
        public void GetCurse()
        {
            curse += 1;
            //gameover
            if (curse >= 100) {
                SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
            }
        }
        //curse effect
        public void CurseEffect(int ink)
        {
            //ลดเยอะขึ้น
            //Perk(comming soon)
        }


    }
}