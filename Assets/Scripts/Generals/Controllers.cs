using UnityEngine;
using System.Collections;

public class Controllers : MonoBehaviour {


    public KeyCode[] ShootButton = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4 };
    public KeyCode SpecialsButton = KeyCode.Q;
    public KeyCode SwapButton = KeyCode.W;

    public bool[] Shoot = new bool[4];
    public bool Special;
    public bool Swap;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        chk_controllers();
	}

    void chk_controllers()
    {
        for (int i = 0; i < ShootButton.Length; i++)
        {
            if (Input.GetKeyDown(ShootButton[i]))
                Shoot[i] = true;
            else
                Shoot[i] = false;
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
