using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhuMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void Start()
    {
        // Override this method to initialize components
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }
    protected virtual void LoadComponents()
    {
        // Override this method to load components
    }

}
