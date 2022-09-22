using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MediatorCanvas : MonoBehaviour
{
    [SerializeField]
    private Sign_In _ingresar;

    [SerializeField]
    private Sign_Up _registrar;

    [SerializeField]
    private Presentacion _presentacion;

     [SerializeField]
    private CharacterSelect _character;
    

    private void Awake()
    {
        _registrar.Configure(this);
        _ingresar.Configure(this);
        _presentacion.Configure(this);
        _character.Configure(this);
        _registrar.Hide();
        _ingresar.Hide();
        _character.Hide();
    }

    public void ViewRegistrar()
    {
        _character.Hide();
        _registrar.Show();
        _ingresar.Hide();
        _presentacion.Hide();
    }

    public void imgFade()
    {
        _character.Hide();
        _registrar.Hide();
        _ingresar.Hide();
        _presentacion.Show();
    }

    public void ViewIngresar()
    {
        _character.Hide();
        _ingresar.Show();
        _registrar.Hide();
        _presentacion.Hide();
    }

  public void ViewSelect()
    {
        _ingresar.Hide();
        _registrar.Hide();
        _presentacion.Hide();
        _character.Show();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
