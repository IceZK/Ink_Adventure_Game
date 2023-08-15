using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceMannage : MonoBehaviour
{
    
    public static ResourceMannage Resouurce_instance;
    public static int wood;
    public static int stone;
    public static float ink;
    public static int day;
    public static float curse;
	// Start is called before the first frame update

	 private void Awake()
    {
        // if the singleton hasn't been initialized yet
        if (Resouurce_instance != null && Resouurce_instance != this)
        {
            Destroy(this.gameObject);
            
        }
        else 
        {
            DontDestroyOnLoad(this.gameObject);
            Resouurce_instance = this;
            
            
        }
    }
    public void GetWood(int Amount_W)
    {
        wood += Amount_W;
    }

	public void GetStone(int Amount_S)
	{
        stone += Amount_S;
	}
    
    public void PayWood(int Amount_W)
    {
        wood -= Amount_W; 
    }

    public void PayStone(int Amount_S)
    {
        stone -= Amount_S; 
    }

    public void GetInk(float Amount_I)
    {
        ink += Amount_I;
    }
	public void PayInk(float Amount_I)
	{
        ink -= Amount_I;
	}

}
