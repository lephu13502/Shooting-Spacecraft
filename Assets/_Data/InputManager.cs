using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get => instance; }
    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get => mouseWorldPos; }
    [SerializeField] protected float onFiring;
    public float OnFiring { get => onFiring; }

    private void Awake()
    {
        if (InputManager.instance != null) Debug.LogError("There is more than one InputManager in the scene!");
        InputManager.instance = this;
    }

    void FixedUpdate()
    {
        this.GetMousePos();
    }
    void Update()
    {
        this.GetMouseDown();
    }
    protected virtual void GetMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    protected virtual void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }

}
