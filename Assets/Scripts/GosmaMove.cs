using System.Collections;
using UnityEngine;

public class GosmaMove : MonoBehaviour {


    public float velocidade;
    public float min;
    public float max;
    public float espera;
    public float vel;
    public float limite;
    public float retorno;



    void Start()
    {
        StartCoroutine(Move(max));
    }
    IEnumerator Move(float destino)
    {
        while (Mathf.Abs(destino - transform.localPosition.y) > 0.2f)
        {
            Vector3 direcao = (destino == max) ? Vector3.up : Vector3.down;
            Vector3 velocidadeVetorial = direcao * velocidade;
            transform.localPosition = transform.localPosition + velocidadeVetorial * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(espera);
        destino = (destino == max) ? min : max;
        StartCoroutine(Move(destino));
    }
    void Update()
    {

        Vector3 velocidadeVetorial = new Vector3(-1f, 0f, 0f) * vel;

        transform.position = transform.position + velocidadeVetorial * Time.deltaTime;

        if (transform.position.y <= limite)
        {
            transform.position = new Vector3(retorno, transform.position.x, transform.position.y);
        }

    }


}

