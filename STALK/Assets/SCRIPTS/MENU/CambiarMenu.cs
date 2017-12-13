using System.Collections;
using UnityEngine;

public class CambiarMenu : MonoBehaviour
{

    public MenuMovil NumeroViejo;
    public int NuevoNumero;
    void OnMouseDown()
    {

        NumeroViejo.NumeroPosicion = NuevoNumero;
    }
}
