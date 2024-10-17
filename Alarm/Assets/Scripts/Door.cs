using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Door : MonoBehaviour
{
    [SerializeField] private UnityEvent _crookEntered;
    [SerializeField] private UnityEvent _crookExit;
    [SerializeField] private Crock _crock;

    private void OnTriggerEnter(Collider collision)
    {
        if (_crock)
        {
            _crookEntered?.Invoke();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (_crock)
        {
            _crookExit?.Invoke();
        }
    }
}
