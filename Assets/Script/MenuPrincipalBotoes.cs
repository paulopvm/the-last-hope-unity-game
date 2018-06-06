using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuPrincipalBotoes : MonoBehaviour {

	public GameObject SobreUI;
	public GameObject MenuUI;
	public GameObject TutorialUI;
	public GameObject Tutorial2UI;
<<<<<<< HEAD
=======
	public GameObject Tutorial3UI;

>>>>>>> Playtest2




	public void Jogar()
	{
		SceneManager.LoadScene (1);
	}

	public void Quit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	}

	public void Menu()
	{
		MenuUI.SetActive (true);
		SobreUI.SetActive (false);
		TutorialUI.SetActive (false);
		Tutorial2UI.SetActive (false);
<<<<<<< HEAD
=======
		Tutorial3UI.SetActive (false);

>>>>>>> Playtest2


	}

	public void Sobre()
	{
		SobreUI.SetActive (true);
		MenuUI.SetActive (false);
		TutorialUI.SetActive (false);

	}

	public void Tutorial()
	{
		SobreUI.SetActive (false);
		MenuUI.SetActive (false);
		TutorialUI.SetActive (true);

	}

	public void ProxTutorial_1()
	{

		TutorialUI.SetActive (false);
		Tutorial2UI.SetActive (true);

	}

<<<<<<< HEAD
=======
	public void ProxTutorial_2()
	{

		Tutorial2UI.SetActive (false);
		Tutorial3UI.SetActive (true);


	}

>>>>>>> Playtest2
	public void VoltarTutorial_1()
	{

		TutorialUI.SetActive (true);
		Tutorial2UI.SetActive (false);

	}
<<<<<<< HEAD
=======

	public void VoltarTutorial_2()
	{

		Tutorial3UI.SetActive (false);
		Tutorial2UI.SetActive (true);

	}
>>>>>>> Playtest2
}