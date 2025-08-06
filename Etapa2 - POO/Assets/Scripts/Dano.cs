using System;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public string tagDoObjeto;
    public int dano = 1;

    public void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == tagDoObjeto)
        {
            int vidas =  colisao.gameObject.GetComponent<Personagens>().getVidas();
            colisao.gameObject.GetComponent<Personagens>().setVidas(vidas-dano);
        }
    }
}