using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tempo : MonoBehaviour {

	public Text tempoFinalText;
	private float countdown = 1f;

	// Update is called once per frame
	void Update () {

		if (GameMaster2.fimJogo == true) {

			tempoFinalText.text = string.Format ("{0:00.00}", countdown);

		} 
		else 
		{
			countdown += Time.deltaTime;

			countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);

		}


		
	}
}
