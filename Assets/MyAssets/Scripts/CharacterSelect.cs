using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    [SerializeField]
    private GameObject Canvas;

    [SerializeField]
    private Button _btnSave;

    private MediatorCanvas _mediator;

    private void Awake()
    {
        _btnSave.onClick.AddListener(() => _mediator.StartGame());
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
