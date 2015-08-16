using UnityEngine;
using System.Collections;

public class Controllers : MonoBehaviour {


    public KeyCode[] ShootButton = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4 };
    public KeyCode SpecialsButton = KeyCode.Q;
    public KeyCode SwapButton = KeyCode.W;

    //public bool[] Shoot = new bool[4];
    public bool Special;
    public bool Swap;
    private TouchControllers Touch;
    private int TouchButtonLen;
    void Awake()
    {
        Touch = GetComponent<TouchControllers>();
        TouchButtonLen = Touch.Shoot.Length;
    }
    // Use this for initialization

	
	// Update is called once per frame
	void Update () 
    {
        chk_controllers();
	}

    void chk_controllers()
    {
        for (int i = 0; i < TouchButtonLen; i++)
        {
            if (Input.GetKeyDown(ShootButton[i]))
                Touch.Shoot[i] = true;
        }
        if (Input.GetKeyDown(SpecialsButton))
            Special = true;
        else
            Special = false;

        if (Input.GetKeyDown(SwapButton))
            Swap = true;
        else
            Swap = false;
    }
}
