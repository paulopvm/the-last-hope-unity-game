using UnityEngine;

public class Enemy2 : MonoBehaviour {

	public float velocidade = 1f;

	private Transform target;
	private int wavepointIndex = 0;

	void Start ()
	{
		target = Waypoints2.points2[0];
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
		if(wavepointIndex >= Waypoints.points.Length - 1)
		{
			Destroy(gameObject);
			StatusJogador.vida -= 1;
			if (StatusJogador.vida == 0) {
				Debug.Log ("MORREU");
			}
			return;
		}

		wavepointIndex++;
		target = Waypoints2.points2[wavepointIndex];
	}
}
