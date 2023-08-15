using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace IceZK_DEV
{
	public class ToNextScene : MonoBehaviour
	{
		public string NextScene;


		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		private void OnCollisionEnter(Collision target)
		{
			if (target.gameObject.tag == ("Player"))
			{

				SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
			}

		}
	}
}

