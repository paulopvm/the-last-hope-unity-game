using UnityEngine;

public class ColocaTorre : MonoBehaviour {

    public static ColocaTorre inst;
	private TorreModelo colocaTorre;
    public GameObject torrePadraoPrefab;


    void Awake()
    {

        if(inst != null)
        {
            return;
        }
        inst = this;
    }
		
	public bool podeConstruir {get{ return colocaTorre != null; }}

	public void ConstroiTorreEm (Base basetorre)
	{
		if (StatusJogador.dinheiro < colocaTorre.custo) {
			return;
		}

		StatusJogador.dinheiro -= colocaTorre.custo;

		GameObject torre = (GameObject) Instantiate(colocaTorre.prefab, basetorre.PegaPosicao(), Quaternion.identity);
		basetorre.torre = torre;

		Debug.Log ("Torre construida! Dinheiro restante: " + StatusJogador.dinheiro);

	}

	public void EscolheTorre(TorreModelo torre)
	{
		colocaTorre = torre;
	}
		

 }
