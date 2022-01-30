using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Routine 
{
    public Coroutine coroutine;
}

public class Routines : MonoBehaviour
{
    public void DoAfter() 
    {
    }
    public void StartCraftCoroutine(Routine _craftCoroutine) 
    {
        if (_craftCoroutine.coroutine != null) 
        {
            StopCoroutine(_craftCoroutine.coroutine);
            _craftCoroutine.coroutine = null;
        }
        // _craftCoroutine.coroutine = StartCoroutine();
    }
}





