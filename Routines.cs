using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Routine 
{
    public Coroutine coroutine;
    public MonoBehaviour monoBehaviour;
}

public class Routines : MonoBehaviour
{
    public void DoAfter() 
    {
    }
    public void StartRoutine(Routine _routine) 
    {
        if (_routine.coroutine != null) 
        {
            StopCoroutine(_routine.coroutine);
            _routine.coroutine = null;
        }
        // _routine.coroutine = _routine.monoBehaviour.StartCoroutine(_routine.coroutine);
    }
}





