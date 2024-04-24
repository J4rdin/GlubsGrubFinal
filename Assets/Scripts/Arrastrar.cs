using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastrar : MonoBehaviour
{
    private bool siendoArrastrado;
    private bool coccionEnCurso;
    private Vector3 posicionInicial;
    private Rigidbody2D rb;
    public static bool sobreSarten = false;


    void Start()
    {
        siendoArrastrado = false;
        coccionEnCurso = false;
        rb = GetComponent<Rigidbody2D>();
        posicionInicial = transform.position;
    }

    void OnMouseDown()
    {
        // Permitir arrastrar solo si no est� en proceso de cocci�n
        if (!coccionEnCurso)
        {
            siendoArrastrado = true;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }
    }  
    
    void OnMouseUp()
    {
        siendoArrastrado = false;
        rb.bodyType = RigidbodyType2D.Dynamic;

        // Verificar si el c�rculo est� sobre la caja derecha
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.2f);
        sobreSarten = false;

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("CajaDerecha"))
            {
                sobreSarten = true;
                break;
            }
        }

        // Ajustar posici�n
        if (sobreSarten && !coccionEnCurso)
        {
            // Calcular posici�n central de la caja derecha
            Vector3 posicionCajaDerecha = new Vector3(1.25f, 0f, 0f); // Ajusta esto seg�n la posici�n de tu caja derecha
            transform.position = posicionCajaDerecha;

            

            // Iniciar temporizador de cocci�n
            coccionEnCurso = true;                     
            TemporizadorCoccion temporizador = FindObjectOfType<TemporizadorCoccion>();
            if (temporizador != null)
            {
                temporizador.IniciarTemporizador();
                coccionEnCurso = false;
                sobreSarten = false;
            }
        }
        else if (!coccionEnCurso)
        {
            transform.position = posicionInicial;
        }
    }

    void Update()
    {
        if (siendoArrastrado && !coccionEnCurso)
        {
            Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(posicionMouse.x, posicionMouse.y, 0);
        }
    }
}
