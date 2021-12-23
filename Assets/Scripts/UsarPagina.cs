using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsarPagina : MonoBehaviour
{
    ObjetosAleatorios oa;
    public AudioSource audioSource;

    void Start()
    {
        oa = (ObjetosAleatorios)GameObject.FindObjectOfType(typeof(ObjetosAleatorios));
    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Debug.Log("Pagina pulsada");
        Gestiondepaginas.paginas++;
        oa.HojaEncontrada();
        audioSource.Play();
        Destroy(gameObject);
    }
}
