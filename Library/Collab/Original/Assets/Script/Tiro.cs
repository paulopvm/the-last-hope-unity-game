using UnityEngine;

public class Tiro : MonoBehaviour {

	private Transform target;

	public float velocidade = 70f;
	public int vidaBoss = 0;

	public GameObject ImpactoEfeito;
	public string enemyTag = "Enemy2";

	public void Procurar (Transform _target)
	{
		target = _target;

	}
		
	
	// Update is called once per frame
	void Update () {

		if (target == null) 
		{

			Destroy (gameObject);
			return;

		}

		Vector3 dir = target.position - transform.position;
		float distanciaFrame = velocidade * Time.deltaTime;

		if (dir.magnitude <= distanciaFrame)
		{
			AcertaAlvo ();
			return;

		}

		transform.Translate (dir.normalized * distanciaFrame, Space.World);
	}

	void AcertaAlvo()
	{
		GameObject instEfeito = Instantiate (ImpactoEfeito, transform.position, transform.rotation);

		Destroy (instEfeito, 2f);
		Debug.Log ("GameObject" + gameObject.tag);
		Debug.Log ("TargetGameObject" + target.gameObject.tag);

		if (target.gameObject.tag == enemyTag) {
			Debug.Log ("Vida boss " + vidaBoss);
			vidaBoss += 1;

		} else {
			Destroy (target.gameObject);
			Destroy(gameObject);
		}


		if (vidaBoss == 10) {
			Destroy (target.gameObject);
			Destroy (gameObject);

		}
		StatusJogador.dinheiro += 1;
	}

}
