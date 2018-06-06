using UnityEngine;
using UnityEngine.UI;

public class Enemy6 : MonoBehaviour {

	public float velocidade = 0.10f;

	private Transform target;
	private int wavepointIndex = 0;

	public float startHealth = 5;
	private float health;

	public Image healthBar;

	void Start ()
	{
		target = Waypoints6.points6[0];

		health = startHealth;
	}

	void Update ()
	{
		Vector3 dir = target.position - transform.position;
		transform.Translate(dir.normalized * velocidade * Time.deltaTime, Space.World);
		Quaternion rotation = Quaternion.LookRotation (dir);
		transform.rotation = Quaternion.Lerp (transform.rotation, rotation, Time.deltaTime * 4);

		if(Vector3.Distance(transform.position, target.position) <= 0.2f)
		{
			GetNextWaypoint();
		}


	}

	void GetNextWaypoint()
	{
		if(wavepointIndex >= Waypoints6.points6.Length - 1)
		{
			Destroy(gameObject);
			StatusJogador.vida -= 1;
			if (StatusJogador.vida == 0) {
				Debug.Log ("MORREU");
			}
			return;
		}

		wavepointIndex++;
		target = Waypoints6.points6[wavepointIndex];
	}

	public void TakeDamage (float amount)
	{
		health -= amount;

		healthBar.fillAmount = health / startHealth;

		if (health <= 0)
		{
			Destroy (gameObject);
			StatusJogador.dinheiro += 50;
		}
	}

}


