using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnGUIManager : SingletonMonoBehaviour<OnGUIManager>
{
    [field: SerializeField] public UnityEvent OnGUIActions { get; private set; }

    public void ToggleEnabled()
    {
        base.enabled = !base.enabled;
    }

    private void OnGUI()
    {
        OnGUIActions.Invoke();
    }
}