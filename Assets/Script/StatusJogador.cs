using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatusJogador : MonoBehaviour {

	public static int dinheiro;
	public int dinheiroInicial;

	public static int vida;
	public int vidaInicial;

	void Start ()
	{
		Scene atual = SceneManager.GetActiveScene ();
		string nomeCena = atual.name;
		if (nomeCena == "MapaPrincipal") {
			dinheiroInicial = 600;
			dinheiro = dinheiroInicial;

			vidaInicial = 3;
			vida = vidaInicial;
		}
		if (nomeCena == "MapaPrincipal2") {
			dinheiroInicial = 1000;
			dinheiro = dinheiroInicial;

			vidaInicial = 5;
			vida = vidaInicial;
		}

	}

}
