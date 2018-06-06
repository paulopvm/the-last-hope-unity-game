using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DinheiroUI : MonoBehaviour {

	public Text dinheiroTexto;
	
	// Update is called once per frame
	void Update () {

		dinheiroTexto.text = StatusJogador.dinheiro.ToString();
		
	}
}
