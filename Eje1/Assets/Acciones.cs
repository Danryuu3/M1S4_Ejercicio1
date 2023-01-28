using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Acciones : MonoBehaviour
{
    public TextMeshProUGUI posibles, opreacion, resultado, etiqueta, retro;
    public TMP_InputField entrada1, entrada2;
    public int puntos = 0;
    public GameObject[] botones;

    private void Start()
    {
        posibles.text = "1, 8, 5, 3";
        opreacion.text = "+";
        resultado.text = "11";
    }

    public void Pregunta1() {

        if(entrada1.text == "8" && entrada2.text == "3")
        {
            puntos++;
        }
        else if (entrada1.text == "3" && entrada2.text == "8")
        {
            puntos++;
        }
        botones[0].SetActive(false);
        botones[1].SetActive(true);

        //Inicializar la Pregunta 2
        posibles.text = "9, 6, 3, 5";
        opreacion.text = "-";
        resultado.text = "6";
        entrada1.text = "";
        entrada2.text = "";
    }

    public void Pregunta2()
    {

        if (entrada1.text == "9" && entrada2.text == "3")
        {
            puntos++;
        }

        botones[1].SetActive(false);
        botones[2].SetActive(true);

        //Inicializar la Pregunta 3
        posibles.text = "1, 5, 9, 2";
        opreacion.text = "+";
        resultado.text = "3";
        entrada1.text = "";
        entrada2.text = "";
    }

    public void Pregunta3()
    {

        if (entrada1.text == "1" && entrada2.text == "2")
        {
            puntos++;
        }
        else if (entrada1.text == "2" && entrada2.text == "1")
        {
            puntos++;
        }
        botones[2].SetActive(false);
        botones[3].SetActive(true);

        //Inicializar la Pregunta 4
        posibles.text = "8, 5, 2, 4";
        opreacion.text = "-";
        resultado.text = "6";
        entrada1.text = "";
        entrada2.text = "";
    }

    public void Pregunta4()
    {

        if (entrada1.text == "8" && entrada2.text == "2")
        {
            puntos++;
        }
        else if (entrada1.text == "2" && entrada2.text == "8")
        {
            puntos++;
        }

        botones[3].SetActive(false);
        botones[4].SetActive(true);

        //Inicializar la Pregunta 5
        posibles.text = "7, 8, 4, 9";
        opreacion.text = "-";
        resultado.text = "5";
        entrada1.text = "";
        entrada2.text = "";
    }
    //5 
    public void Pregunta5()
    {

        if (entrada1.text == "4" && entrada2.text == "9")
        {
            puntos++;
        }
        else if (entrada1.text == "9" && entrada2.text == "4")
        {
            puntos++;
        }

        botones[4].SetActive(false);
        botones[5].SetActive(true);

        //Inicializar la Pregunta 5
        posibles.text = "1, 2, 11, 15";
        opreacion.text = "+";
        resultado.text = "13";
        entrada1.text = "";
        entrada2.text = "";
    }
    //6
    public void Pregunta6()
    {

        if (entrada1.text == "11" && entrada2.text == "2")
        {
            puntos++;
        }
        else if (entrada1.text == "2" && entrada2.text == "11")
        {
            puntos++;
        }

        botones[5].SetActive(false);
        botones[6].SetActive(true);

        //Inicializar la Pregunta 5
        posibles.text = "3, 22, 7, 4";
        opreacion.text = "-";
        resultado.text = "15";
        entrada1.text = "";
        entrada2.text = "";
    }
    //7
    public void Pregunta7()
    {

        if (entrada1.text == "22" && entrada2.text == "7")
        {
            puntos++;
        }
        else if (entrada1.text == "7" && entrada2.text == "22")
        {
            puntos++;
        }

        botones[6].SetActive(false);
        botones[7].SetActive(true);

        //Inicializar la Pregunta 5
        posibles.text = "11, 3, 5, 2";
        opreacion.text = "-";
        resultado.text = "9";
        entrada1.text = "";
        entrada2.text = "";
    }
    //8
    public void Pregunta8()
    {

        if (entrada1.text == "11" && entrada2.text == "2")
        {
            puntos++;
        }
        else if (entrada1.text == "2" && entrada2.text == "11")
        {
            puntos++;
        }

        botones[7].SetActive(false);
        botones[8].SetActive(true);

        //Inicializar la Pregunta 5
        posibles.text = "3, 22, 7, 4";
        opreacion.text = "+";
        resultado.text = "29";
        entrada1.text = "";
        entrada2.text = "";
    }
    //9
    public void Pregunta9()
    {

        if (entrada1.text == "22" && entrada2.text == "7")
        {
            puntos++;
        }
        else if (entrada1.text == "7" && entrada2.text == "22")
        {
            puntos++;
        }

        botones[8].SetActive(false);
        botones[9].SetActive(true);

        //Inicializar la Pregunta 5
        posibles.text = "3, 1, 2, 5";
        opreacion.text = "+";
        resultado.text = "5";
        entrada1.text = "";
        entrada2.text = "";
    }
    //10
    public void Pregunta10()
    {

        if (entrada1.text == "3" && entrada2.text == "2")
        {
            puntos++;
        }
        else if (entrada1.text == "2" && entrada2.text == "3")
        {
            puntos++;
        }

        botones[9].SetActive(false);
        posibles.gameObject.SetActive(false);
        opreacion.gameObject.SetActive(false);
        resultado.gameObject.SetActive(false);
        entrada1.gameObject.SetActive(false);
        entrada2.gameObject.SetActive(false);
        etiqueta.gameObject.SetActive(false);
        botones[10].SetActive(true);

    }

    //Esconder entras y etiquetas
    //mostrar RRETO
    public void MostrarRetro()
    {
        posibles.gameObject.SetActive(false);
        opreacion.gameObject.SetActive(false);
        resultado.gameObject.SetActive(false);
        entrada1.gameObject.SetActive(false);
        entrada2.gameObject.SetActive(false);
        etiqueta.gameObject.SetActive(false);
        botones[10].SetActive(false);
        retro.gameObject.SetActive(true);
        if (puntos <= 6)
        {
            //RETRO propiedad TEXT pornerle el valor "------"
            retro.text = "Puedes mejorar";
        }
        else if(puntos <= 9)
        {
            retro.text = "Ya casi eres el mejor";
        }
        else if(puntos == 10)
        {
            retro.text = "eres el rey pirata";
        }
    }
}
