using UnityEngine;

public class Loja : MonoBehaviour {

	public TorreModelo torre1;
	public TorreModelo torre2;
	ColocaTorre construir;

	void Start()
	{
		construir = ColocaTorre.inst;
	}

    public void SelecionaTorre1()
    {
        Debug.Log("comprou torre 1");
		construir.EscolheTorre(torre1);
    }

	public void SelecionaTorre2()
	{
		Debug.Log("comprou torre 2");
		construir.EscolheTorre(torre2);
	}


}
