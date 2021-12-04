//Usamos clases por defecto de Unity
using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
//Esta clase determina la funcionalidad que tendra las diferentes opciones de las preguntas relacionadas a los botones.
//Creamos nuestra propia clase "Botonopciones"
public class botonopciones : MonoBehaviour
{
   private Text m_texto = null;
   private Button m_boton = null;
   private Image m_imagen = null;
   private Color m_ColorOriginal = Color.black;
    
    public opciones opcion { get; set; }
    //Aquí nos encargamos de asignar las variables al tipo de elemento de vamos a utilizar.
    private void Awake()
    {
        m_boton = GetComponent<Button>();
        m_imagen = GetComponent<Image>();
        m_texto = transform.GetChild(0).GetComponent<Text>();
    }

    //Aquí convertimos los datos
    public void Constructor (opciones opciones, Action<botonopciones> callback)
    {
        m_texto.text = opcion.text;
        m_boton.enabled = true;
        m_imagen.color = m_ColorOriginal;
    }

    //Metodo Para validar la pregunta correcta mediante el color.
    public void SetColor(Color c)
    {
        m_boton.enabled = true;
        m_imagen.color=c;
    }

}
