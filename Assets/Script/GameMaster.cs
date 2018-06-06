using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

    public static bool fimJogo;
	public static int sorteiaSpawn;
	private float countdown = 3f;
	private float tempoVenceu = 120f;

	public Text tempoVenceuText;
	public GameObject fimJogoUI;
	public GameObject fimJogoVenceuUI;


	void Start()
	{
		fimJogo = false;
		sorteiaSpawn = 0;
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
			sorteiaSpawn = (int) Random.Range (1f, 4f);
			countdown = 5f;

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
