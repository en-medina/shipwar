﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TouchControllers : MonoBehaviour {

    public bool[] Shoot;
    public bool Special;
    
    private RuntimePlatform platform;
    private SwapShips WasTouched;
    private GameObject ShipTouched;

    void Awake()
    {
        Shoot = new bool[4];
        WasTouched = gameObject.GetComponent<SwapShips>();
        platform = Application.platform;
    }
    void Update()
    {
        if (platform == RuntimePlatform.Android || platform == RuntimePlatform.IPhonePlayer)
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    Debug.Log("Touch Position" + Input.GetTouch(0).position);
                    ApplyForce(Input.GetTouch(0).position);
                }
            }
        }
        else if (platform == RuntimePlatform.WindowsEditor)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Mouse Position: " + Input.mousePosition);
                ApplyForce(Input.mousePosition);
            }
        }
    }

    void ApplyForce(Vector3 position)
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(position);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
        if (hit != null && hit.collider != null)
        {
            //  Debug.Log("I'm hitting " + hit.collider.name);
            if (hit.collider.tag == Tags.Player)
            {
                ShipTouched = hit.collider.gameObject;
                //Debug.Log("Position: " + ShipTouched.PositionID);
                WasTouched.IsTimeToSwap(ShipTouched);
            }
        }
    }
    public void OnTouch(int position)
    {
        Shoot[position - 1] = true;
    }
}
