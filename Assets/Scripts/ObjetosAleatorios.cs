using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjetosAleatorios : MonoBehaviour
{
    public GameObject[] _objetos;
    public List<GameObject> listaObjetos;
    public GameObject objetoCreado;
    public GameObject objetoSeleccionado;
    // Start is called before the first frame update
    void Start()
    {
        listaObjetos = _objetos.ToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MuestraObjetoAleatorio()
    {
        Debug.Log("Muestra objetos");
        objetoSeleccionado = listaObjetos[Random.Range(0, listaObjetos.Count)];
        objetoCreado = Instantiate(objetoSeleccionado, transform);
        
        
    }

    public void HojaEncontrada()
    {
        listaObjetos.Remove(objetoSeleccionado);
    }

    public void BateriaEncontrada()
    {
        listaObjetos.Remove(objetoSeleccionado);
    }

    public void DestruyeObjetoCreado()
    {
        Destroy(objetoCreado);
    }
}
