using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner6 : MonoBehaviour
{

	public static int EnemiesAlive = 0;
	//public Wave[] waves;

	public Transform enemyPrefab;
	public Transform spawnPoint;

	public float timeBetweenWaves = 6f;

	private float countdown = 3f;
	private bool liberaWave = false;
	public Text waveCountdownText;

	//public GameManager gameManager;

	private int waveIndex = 0;




	void Update()
	{
		if (GameMaster2.liberaBoss2 == 5) {
			Debug.Log ("vem monstro");
			liberaWave = true;
		}
		//if (EnemiesAlive > 0)
		//{
		//	return;
		//}

		//if (waveIndex == waves.Length)
		//{
		//	gameManager.WinLevel();
		//	this.enabled = false;
		//}
		if (liberaWave == true) {
			if (countdown <= 0f) {
				SpawnEnemy ();
				liberaWave = false;
				GameMaster2.liberaBoss2 = 0;
				enabled = false;
				return;
			}

			countdown -= Time.deltaTime;

			countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);

			waveCountdownText.text = string.Format ("{0:00.00}", countdown);
		}

	}

	void SpawnEnemy()
	{
		Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
	}

}