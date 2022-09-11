using UnityEngine;
using UnityEngine.UI;

public class Sign_In : MonoBehaviour
{
    [SerializeField]
    private Button _btningresar;

    [SerializeField]
    private Button _btnregistrar;

    [SerializeField]
    private GameObject Canvas;

    private MediatorCanvas _mediator;

    private void Awake()
    {
        _btningresar.onClick.AddListener(() => _mediator.StartGame());
        _btnregistrar.onClick.AddListener(() => _mediator.ViewRegistrar());
    }

    public void Configure(MediatorCanvas mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {
        Canvas. SetActive(true);
    }

    public void Hide()
    {
        Canvas. SetActive(false);
    }
}
