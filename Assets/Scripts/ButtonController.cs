using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public static bool AtBread = false;
    public static bool AtClientes = true;
    public GameObject BoxFront;
    public GameObject BoxBack;
    public GameObject canvasClientes;
    void Update()
    {
        if (AtBread == true)
        {
            BoxBack.SetActive(false);
            BoxFront.SetActive(false);
        }
        else
        {
            BoxFront.SetActive(true);
            BoxBack.SetActive(true);
        }

        if (AtClientes == true)
        {
            canvasClientes.SetActive(true);
        }
        else
        {
            canvasClientes.SetActive(false);
        }
    }

    public void GoBread()
    {
        AtBread = true;
        AtClientes = false;
        SceneManager.LoadScene("Bread", LoadSceneMode.Additive);
        if (SceneManager.GetSceneByName("Meat").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Meat");
        }
        if (SceneManager.GetSceneByName("ToppingsYSalsas").isLoaded)
        {
            SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        }
        if (Player.item != "0000")
            DestroyFood();
    }
    public void GoMeat()
    {
        AtBread = false;
        AtClientes = false;
        SceneManager.LoadScene("Meat", LoadSceneMode.Additive);
        if (SceneManager.GetSceneByName("ToppingsYSalsas").isLoaded)
        {
            SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        }
        if (SceneManager.GetSceneByName("Bread").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Bread");
        }
        if (Player.item != "0000")
            DestroyFood();
    }
    public void GoToppings()
    {
        AtBread = false;
        AtClientes = false;
        SceneManager.LoadScene("ToppingsYSalsas", LoadSceneMode.Additive);
        if (SceneManager.GetSceneByName("Bread").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Bread");
        }
        if (SceneManager.GetSceneByName("Meat").isLoaded)
        {
            SceneManager.UnloadSceneAsync("Meat");
        }
        if (Player.item != "0000")
            DestroyFood();
    }

    public void Playgame()
    {
        SceneManager.LoadScene("Clientes");
    }

    public void GoOptions()
    {
        SceneManager.LoadScene("Options", LoadSceneMode.Additive);
    }

    public void GoPause()
    {
        SceneManager.LoadScene("Pause");
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoBackOptions()
    {
        SceneManager.UnloadSceneAsync("Options");
    }
    public void GoBackMeat()
    {
        AtClientes = true;
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Meat");
        //if (Player.item != "0000")
        //    DestroyFood();
    }
    public void GoBackBread()
    {
        AtBread = false;
        AtClientes = true;
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Bread");
        //if (Player.item != "0000")
        //    DestroyFood();
    }

    public void GoBackClients()
    {
        WorkStation.entered = false;
        SceneManager.UnloadSceneAsync("Clientes");
        //Player.item = "0000";
    }

    public void GoBackToppings()
    {
        AtClientes = true;
        SceneManager.UnloadSceneAsync("ToppingsYSalsas");
        //if (Player.item != "0000")
        //    DestroyFood();
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
