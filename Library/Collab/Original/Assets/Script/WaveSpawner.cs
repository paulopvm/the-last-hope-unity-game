using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{

    public static int EnemiesAlive = 0;

    //public Wave[] waves;

    public Transform enemyPrefab;
    public Transform spawnPoint;

    public float timeBetweenWaves = 6f;
    private float countdown = 2f;
	private int minInimigo = 1;
	private int maxInimigo = 3;

	private bool liberaWave = false;

    public Text waveCountdownText;

    //public GameManager gameManager;

    private int waveIndex = 0;


    void Update()
    {
		if (GameMaster2.sorteiaSpawn == 1) {
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
				StartCoroutine (SpawnWave ());
				countdown = timeBetweenWaves;
				return;
			}



			countdown -= Time.deltaTime;

			countdown = Mathf.Clamp (countdown, 0f, Mathf.Infinity);

			waveCountdownText.text = string.Format ("{0:00.00}", countdown);

		}


    }

    IEnumerator SpawnWave()
    {
        //PlayerStats.Rounds++;

        //Wave wave = waves[waveIndex];

        //EnemiesAlive = wave.count;

        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }


		waveIndex = Random.Range(minInimigo,maxInimigo); //numero de inimigo aleatorio

		minInimigo++;
		maxInimigo++;
		//waveIndex++;
		//timeBetweenWaves = Random.Range (4f, 5f); //tempo de spawnar aleatorio

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }

}