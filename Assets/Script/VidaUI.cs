using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaUI : MonoBehaviour {

	public Text vidaTexto;

	// Update is called once per frame
	void Update () {

		vidaTexto.text = StatusJogador.vida.ToString();

	}
}
