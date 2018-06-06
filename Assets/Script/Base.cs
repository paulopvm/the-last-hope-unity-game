using UnityEngine;

public class Base : MonoBehaviour {

	public Color mudaCor;

    public Vector3 offsetPosicao;
    public GameObject torre;


	private Renderer rend;
	private Color corInicial;
	ColocaTorre construir;



	void Start()
	{
		rend = GetComponent<Renderer> ();
		corInicial = rend.material.color;
		construir = ColocaTorre.inst;

	}

	public Vector3 PegaPosicao ()
	{
		return transform.position + offsetPosicao;
	}

    void OnMouseDown()
    {
		if (!construir.podeConstruir) {
			return;
		}

        if(torre != null)
        {
            Debug.Log("Não pode construir aqui");
            return;
        }

		construir.ConstroiTorreEm (this);

    }

	void OnMouseEnter()
	{
		if (!construir.podeConstruir) {
			return;
		}
			
		rend.material.color = mudaCor;




	}

	void OnMouseExit()
	{
		rend.material.color = corInicial;
	}



}
