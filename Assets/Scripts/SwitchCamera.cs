using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject TPCamera;
    public GameObject FPCamera;
    private bool _switch = true;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            TPCamera.SetActive(_switch);
            FPCamera.SetActive(!_switch);
            _switch = !_switch;
        }
    }
}
