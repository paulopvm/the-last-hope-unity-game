using UnityEngine;

public class Tiro : MonoBehaviour {

	private Transform target;

	public float velocidade = 70f;
	public GameObject ImpactoEfeito;
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
		Destroy (target.gameObject);
		Destroy(gameObject);

		StatusJogador.dinheiro += 1;
	}

}
