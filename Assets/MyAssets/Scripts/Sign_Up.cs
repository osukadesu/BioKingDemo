using UnityEngine;
using UnityEngine.UI;

public class Sign_Up : MonoBehaviour
{
    
    [SerializeField]
    private Button _btnCharacterSelect;

    [SerializeField]
    private GameObject Canvas;

    private MediatorCanvas _mediator;

    private void Awake()
    {
        _btnCharacterSelect.onClick.AddListener(() => _mediator.ViewSelect());
    }

    public void Configure(MediatorCanvas mediator)
    {
        _mediator = mediator;
    }

    public void Show()
    {
        Canvas.SetActive(true);
    }

    public void Hide()
    {
        Canvas.SetActive(false);
    }
}
