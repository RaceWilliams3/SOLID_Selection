﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionManager : MonoBehaviour
{

    private ISelectionResponse _selectionResponse;
    private ISelector _selector;
    private IRayProvider _rayProvider;

    private Transform _currentSelection;

    private void Awake()
    {
        SceneManager.LoadScene("Environment", LoadSceneMode.Additive);
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
        _selectionResponse = GetComponent<ISelectionResponse>();
        _rayProvider = GetComponent<IRayProvider>();
        _selector = GetComponent<ISelector>();
    }

    private void Update()
    {
        if (_currentSelection != null)
            _selectionResponse.OnDeselect(_currentSelection);

        _selector.Check(_rayProvider.CreateRay());
        _currentSelection = _selector.GetSelection();

        if (_currentSelection != null)
            _selectionResponse.OnSelect(_currentSelection);
    }

    
}



