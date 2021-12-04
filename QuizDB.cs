using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se crea Clase QuizBD que sera llamada en el objeto de Unity para agregar el banco de preguntas mediante interfaz grafica.
public class QuizDB : MonoBehaviour
{
    [SerializeField] private List<pregunta> lista_preguntas = null;
}
