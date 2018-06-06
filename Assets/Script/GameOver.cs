using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {


	public void Retry () {

		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);

	}
		

	public void VoltarMenu () {

		SceneManager.LoadScene (0);

	}

	public void fase2 () {

		SceneManager.LoadScene (2);

	}

	public void fase1 () {

		SceneManager.LoadScene (1);

	}

}
