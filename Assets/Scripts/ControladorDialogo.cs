using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControladorDialogo : MonoBehaviour
{
    public Text textoDialogo;
    public string[] lineasDialogo;
    public Button[] botonesRespuesta;
    public GameObject panel;
    private int indiceLinea = 0;
    int SpriteChoice = 1; /***/
    int PreviousClient = 1;

    public GameObject Client;

    public Sprite ClientX;
    public Sprite Client1;
    public Sprite Client2;
    public Sprite Client3;
    public Sprite Client4; /***/
    public Sprite Client5;
    public Sprite Client6;

    int panes = 0;
    int carnes = 0;
    int toppings = 0;
    int salsas = 0;

    public RawImage img_panes;
    public RawImage img_carnes;
    public RawImage img_toppings;
    public RawImage img_salsas;

    public RawImage img_estadoanimo;
    int estado_animo = 0;

    bool dialogo_ended = false;

    public static string pedido = "";       //Pan - Carne - Salsa - Topping

    public int propinas = 3;
    public static int dinero = 0;

    public int neutrochoice = 0;
    bool pedido_entregable = false;

    int num_pedidos_dia = 0;
    int num_max_pedidos_dia = 6;
    int dia = 1;



    void Start()
    {
        int SpriteChoice = 1; /***/
        int PreviousClient = 1;
        PedirComida(); /***/
    }

    public void PedirComida() /***/
    {
        GenerarEstado();  //Estados de animo
        ActivarImagenPedido(false);  //Desactivar las imágenes al principio
        ActivarBotonesRespuesta(false);  // Desactivar los botones al principio
        MostrarSiguienteLinea();
        ActualizarValoresDia();
        neutrochoice = Random.Range(0, 2); // 0 = Enfadado , 1 = Feliz
        print(pedido);
    } /***/

    void Update()
    {
        // Detectar clic del mouse
        if (Input.GetMouseButtonDown(0) && dialogo_ended == false)
        {
            MostrarSiguienteLinea();
        }

    }

    void MostrarSiguienteLinea()
    {
        if (indiceLinea < lineasDialogo.Length) //Muestra dialogo hasta el final
        {
            textoDialogo.text = lineasDialogo[indiceLinea];
            indiceLinea++;
        }
        else
        {
            ActivarBotonesRespuesta(true);  // Activar botones al final del diálogo            
        }
    }

    public void DarPedido()
    {
        if (pedido_entregable == true)
        {
            StartCoroutine(ActivarPanel());
            if (Player.item == pedido && pedido_entregable == true)
            {
                pedido = ""; /***/
                print("Bien????");
                textoDialogo.text = "¡Muchas gracias!"; //Lo que dice al darle el pedido bien
                dinero = dinero + 10 + propinas;
                DestroyFood(); /***/
                print("Past Destroy Food");
                num_pedidos_dia++;
                if (num_pedidos_dia >= num_max_pedidos_dia)
                {
                    CambioDeDia();
                }
                print("Past CambioDeDia");
                //Sprite change
                SpriteChoice = Random.Range(1, 7); /***/
                print("Random Client = ");
                print(SpriteChoice);
                if (SpriteChoice == PreviousClient)
                {
                    SpriteChoice += 1;
                    print("+1 to sprite choice");
                    if (SpriteChoice == 7)
                    {
                        SpriteChoice = 1;
                        print("5->1");
                    }
                }
                PreviousClient = SpriteChoice;
                switch (SpriteChoice)
                {
                    case 1:
                        print("Client = Inspector");
                        ClientX = Client1;
                        StartCoroutine(Waiter()); //Waiter
                        break;
                    case 2:
                        print("Client = Benedi");
                        ClientX = Client2;
                        StartCoroutine(Waiter()); //Waiter
                        break;
                    case 3:
                        print("Client = Ainara");
                        ClientX = Client3;
                        StartCoroutine(Waiter()); //Waiter
                        break;
                    case 4:
                        print("Client = Manuel");
                        ClientX = Client4;
                        StartCoroutine(Waiter()); //Waiter
                        break;
                    case 5:
                        print("Client = Victor");
                        ClientX = Client5;
                        StartCoroutine(Waiter()); //Waiter
                        break;
                    case 6:
                        print("Client = Camas");
                        ClientX = Client6;
                        StartCoroutine(Waiter()); //Waiter
                        break;
                }
                Player.item = "0000";
                PedirComida(); /***/
            }
            else if (Player.item != pedido && pedido_entregable == true)
            {
                print("MAl????");
                textoDialogo.text = "¡No es lo que he pedido chico!"; //Lo que dice al darle el pedido mal                
            }

        }

    }

    IEnumerator Waiter() /***/
    {
        print("Inside Waiter");
        ClienteAppear.ComeToOrigen = true;
        print("Past Origen");
        yield return new WaitForSeconds(2);
        Client.gameObject.GetComponent<SpriteRenderer>().sprite = ClientX;
        ClienteAppear.activarTransicion = true;
        print("Past Transicion");
    } /***/

    IEnumerator ActivarPanel()
    {
        panel.gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        panel.gameObject.SetActive(false);
    }
    public void SeleccionarRespuesta(int respuestaIndex)
    {
        // Lógica para cada respuesta

        switch (respuestaIndex)
        {
            case 0:
                // Acciones para la primera respuesta /Enfadado
                print("Opcion 1");

                if (estado_animo == 3) //Si elige enfadado
                {
                    propinas *= 2;
                }
                if (estado_animo == 2 && neutrochoice == 0) //Neutro elige enfadado
                {
                    propinas *= 4;
                }
                if (estado_animo == 1) //Si elige feliz
                {
                    propinas = 0;
                }

                break;
            case 1:
                // Acciones para la segunda respuesta /Neutro
                print("Opcion 2");

                break;
            case 2:
                // Acciones para la tercera respuesta /Feliz
                print("Opcion 3");

                if (estado_animo == 1) //Si elige feliz
                {
                    propinas *= 2;
                }
                if (estado_animo == 2 && neutrochoice == 1) //Neutro elige feliz
                {
                    propinas *= 4;
                }
                if (estado_animo == 3) //Si elige triste
                {
                    propinas = 0;
                }
                break;
        }

        CerrarDialogo();
        dialogo_ended = true;
        GenerarPedido();
    }

    void CerrarDialogo()
    {
        ActivarBotonesRespuesta(false);  // Desactivar botones al cerrar el diálogo
        ActivarImagenPedido(true); //Activar imagenes
        panel.gameObject.SetActive(false);
        print("Fin dialogo");
    }

    void ActivarBotonesRespuesta(bool activar)
    {
        foreach (Button boton in botonesRespuesta)
        {
            boton.gameObject.SetActive(activar);
        }
    }

    void ActivarImagenPedido(bool activar)
    {
        img_panes.gameObject.SetActive(activar);
        img_carnes.gameObject.SetActive(activar);
        img_toppings.gameObject.SetActive(activar);
        img_salsas.gameObject.SetActive(activar);
    }

    void GenerarPedido()
    {
        if (dia == 1)
        {
            GenerarPedidoDia_1();
        }
        else if (dia == 2)
        {
            GenerarPedidoDia_2();
        }
        else if (dia == 3)
        {
            GenerarPedidoDia_3();
        }
        else if (dia == 4 || dia == 5 || dia == 6 || dia == 7)
        {
            GenerarPedidoDia_4_5_6_7();
        }


        print(pedido);
        pedido_entregable = true;

    }


    void GenerarEstado()
    {
        estado_animo = Random.Range(1, 4); //Estados animo
        img_estadoanimo.gameObject.SetActive(true);

        switch (estado_animo)
        {
            case 1:
                img_estadoanimo.texture = Resources.Load<Texture>("Estado1");  //Feliz
                print("Feliz");
                break;
            case 2:
                img_estadoanimo.texture = Resources.Load<Texture>("Estado2");  //Neutro
                print("Neutro");
                break;
            case 3:
                img_estadoanimo.texture = Resources.Load<Texture>("Estado3");  //Enfadado
                print("Enfadado");
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }
    }

    void CambioDeDia()
    {
        dia++;
        num_pedidos_dia = 0;
        if (dia > 7)
        {
            print("FIN DEL JUEGO, NO HAY MAS DÍAS");
        }
        ActualizarValoresDia();
    }
    void ActualizarValoresDia()
    {
        if (dia == 1)
        {
            num_max_pedidos_dia = 6;
        }
        else
        {
            num_max_pedidos_dia = 10;
        }

    }

    void GenerarPedidoDia_1() //Un pan, 3 carnes
    {
        panes = 1;
        carnes = Random.Range(1, 3); //The number is wrong but the food simply hastn been added yet NVM
        toppings = 0;
        salsas = 0;

        switch (panes)  //Añadir panes
        {
            case 1:
                img_panes.texture = Resources.Load<Texture>("Panes1");
                print("Pan 1");
                pedido += "1";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (carnes)
        {
            case 1:
                img_carnes.texture = Resources.Load<Texture>("Carnes1");
                print("Carne 1");
                pedido += "1";
                break;
            case 2:
                img_carnes.texture = Resources.Load<Texture>("Carnes2");
                print("Carne 2");
                pedido += "2";
                break;
            case 3:
                img_carnes.texture = Resources.Load<Texture>("Carnes3");
                print("Carne 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        pedido += 0; //Sin toppings 
        print("Sin toppings");
        pedido += 0; //Sin salsas
        print("Sin salsas");
    }

    void GenerarPedidoDia_2() //Un pan, 3 carnes, 3 salsas
    {
        panes = 1;
        carnes = Random.Range(1, 4);
        salsas = Random.Range(1, 4);

        switch (panes)  //Añadir panes
        {
            case 1:
                img_panes.texture = Resources.Load<Texture>("Panes1");
                print("Pan 1");
                pedido += "1";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (carnes)
        {
            case 1:
                img_carnes.texture = Resources.Load<Texture>("Carnes1");
                print("Carne 1");
                pedido += "1";
                break;
            case 2:
                img_carnes.texture = Resources.Load<Texture>("Carnes2");
                print("Carne 2");
                pedido += "2";
                break;
            case 3:
                img_carnes.texture = Resources.Load<Texture>("Carnes3");
                print("Carne 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (salsas)
        {
            case 1:
                img_salsas.texture = Resources.Load<Texture>("Salsas1");
                print("Salsas 1");
                pedido += "1";
                break;
            case 2:
                img_salsas.texture = Resources.Load<Texture>("Salsas2");
                print("Salsas 2");
                pedido += "2";
                break;
            case 3:
                img_salsas.texture = Resources.Load<Texture>("Salsas3");
                print("Salsas 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        pedido += 0; //Sin toppings 
        print("Sin toppings");
    }

    void GenerarPedidoDia_3() //Un pan, 3 carnes, 3 salsas, 3 topppings
    {
        panes = 1;
        carnes = Random.Range(1, 4);
        salsas = Random.Range(1, 3);
        toppings = Random.Range(1, 4);

        switch (panes)
        {
            case 1:
                img_panes.texture = Resources.Load<Texture>("Panes1");
                print("Pan 1");
                pedido += "1";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (carnes)
        {
            case 1:
                img_carnes.texture = Resources.Load<Texture>("Carnes1");
                print("Carne 1");
                pedido += "1";
                break;
            case 2:
                img_carnes.texture = Resources.Load<Texture>("Carnes2");
                print("Carne 2");
                pedido += "2";
                break;
            case 3:
                img_carnes.texture = Resources.Load<Texture>("Carnes3");
                print("Carne 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (salsas)
        {
            case 1:
                img_salsas.texture = Resources.Load<Texture>("Salsas1");
                print("Salsas 1");
                pedido += "1";
                break;
            case 2:
                img_salsas.texture = Resources.Load<Texture>("Salsas2");
                print("Salsas 2");
                pedido += "2";
                break;
            case 3:
                img_salsas.texture = Resources.Load<Texture>("Salsas3");
                print("Salsas 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (toppings)
        {
            case 1:
                img_toppings.texture = Resources.Load<Texture>("Toppings1");
                print("Toppings 1");
                pedido += "1";
                break;
            case 2:
                img_toppings.texture = Resources.Load<Texture>("Toppings2");
                print("Toppings 2");
                pedido += "2";
                break;
            case 3:
                img_toppings.texture = Resources.Load<Texture>("Toppings3");
                print("Toppings 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }
    }

    void GenerarPedidoDia_4_5_6_7() //3 panes, 3 carnes, 3 salsas, 3 topppings
    {
        panes = Random.Range(1, 4);
        carnes = Random.Range(1, 4);
        salsas = Random.Range(1, 3);
        toppings = Random.Range(1, 4);

        switch (panes)
        {
            case 1:
                img_panes.texture = Resources.Load<Texture>("Panes1");
                print("Pan 1");
                pedido += "1";
                break;
            case 2:
                img_panes.texture = Resources.Load<Texture>("Panes2");
                print("Pan 2");
                pedido += "2";
                break;
            case 3:
                img_panes.texture = Resources.Load<Texture>("Panes3");
                print("Pan 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (carnes)
        {
            case 1:
                img_carnes.texture = Resources.Load<Texture>("Carnes1");
                print("Carne 1");
                pedido += "1";
                break;
            case 2:
                img_carnes.texture = Resources.Load<Texture>("Carnes2");
                print("Carne 2");
                pedido += "2";
                break;
            case 3:
                img_carnes.texture = Resources.Load<Texture>("Carnes3");
                print("Carne 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (salsas)
        {
            case 1:
                img_salsas.texture = Resources.Load<Texture>("Salsas1");
                print("Salsas 1");
                pedido += "1";
                break;
            case 2:
                img_salsas.texture = Resources.Load<Texture>("Salsas2");
                print("Salsas 2");
                pedido += "2";
                break;
            case 3:
                img_salsas.texture = Resources.Load<Texture>("Salsas3");
                print("Salsas 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }

        switch (toppings)
        {
            case 1:
                img_toppings.texture = Resources.Load<Texture>("Toppings1");
                print("Toppings 1");
                pedido += "1";
                break;
            case 2:
                img_toppings.texture = Resources.Load<Texture>("Toppings2");
                print("Toppings 2");
                pedido += "2";
                break;
            case 3:
                img_toppings.texture = Resources.Load<Texture>("Toppings3");
                print("Toppings 3");
                pedido += "3";
                break;
            default:
                Debug.LogError("Número aleatorio fuera de rango");
                break;
        }
    }

    public void DestroyFood()
    {
        GameObject[] objectsToDestroy = GameObject.FindGameObjectsWithTag(Player.item);

        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }

}