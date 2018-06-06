using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster2 : MonoBehaviour {

	public static bool fimJogo;
	public static int sorteiaSpawn;
	public static int liberaBoss;
	public static int liberaBoss2;

	private float countdown = 3f;
	private float tempoVenceu = 150f;

	public Text tempoVenceuText;
	public GameObject fimJogoUI;
	public GameObject fimJogoVenceuUI;


	void Start()
	{
		fimJogo = false;
		//sorteiaSpawn = (int) Random.Range (1f, 4f);

	}
	// Update is called once per frame
	void Update () {

		if (fimJogo)
			return;

		if(StatusJogador.vida <= 0)
		{
			terminaJogo ();
		}

		if (tempoVenceu <= 0f) {
			terminaJogoVenceu ();
		}



		if (countdown <= 0f) {
			sorteiaSpawn = (int) Random.Range (1f, 5f);
			countdown = 10f;

		}

		if (tempoVenceu <= 75f) {
			liberaBoss = 5;

		}

		if (tempoVenceu <= 30f) {
			liberaBoss2 = 5;

		}

		tempoVenceu -= Time.deltaTime;

		tempoVenceu = Mathf.Clamp (tempoVenceu, 0f, Mathf.Infinity);
		tempoVenceuText.text = string.Format ("{0:00.00}", tempoVenceu);

		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);

	}

	void terminaJogo()
	{
		fimJogo = true;
		fimJogoUI.SetActive (true);
	}

	void terminaJogoVenceu()
	{
		fimJogo = true;
		fimJogoVenceuUI.SetActive (true);
	}

}
