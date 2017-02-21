
using UnityEngine;

public class PranchaMove : MonoBehaviour {


    public float velocidade;

    void Start () {  	
	}

    void Update () {

        Vector3 velocidadeVetorial = new Vector3(-1f, 0f, 0f) * velocidade;

        transform.position = transform.position + velocidadeVetorial * Time.deltaTime;

		
	}
}
