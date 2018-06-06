using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour {

	public GameObject ui;
	public AudioSource backgroundMusic;

	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.Escape)) {

			Toggle ();
		}
	}

	public void Toggle ()
	{
		ui.SetActive (!ui.activeSelf);

		if (ui.activeSelf) {
			backgroundMusic.Pause ();
			Time.timeScale = 0f; //para o tempo no mundo do jogo

		} else {
			backgroundMusic.Play ();
			Time.timeScale = 1f;
		}
	}

	public void Reiniciar()
	{
		Toggle ();
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	public void Menu ()
	{
		SceneManager.LoadScene (0);
	}
}
