using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gestiondepaginas : MonoBehaviour
{
    public TextMeshProUGUI numpaginas;
    public static int paginas = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numpaginas.text = paginas.ToString();
    }
}
