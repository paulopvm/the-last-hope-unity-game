using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPrincipalBotoes : MonoBehaviour {

	public void Jogar()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void Quit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	}
}