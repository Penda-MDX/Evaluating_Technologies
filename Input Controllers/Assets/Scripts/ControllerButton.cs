using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ControllerButton : MonoBehaviour
{
    public Image PressImage;
    public Sprite PressSprite;
    public Sprite PressSpriteHighlight;
    public InputActionReference PressActionRef;
    public float highlgihtTime = 2.0f;

    private bool _pressed;
    private float _pressTimeOut;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_pressed && _pressTimeOut<Time.time) 
        { 
            _pressed = false;
            PressImage.sprite = PressSprite;
        }
    }
    private void onPressed(InputAction.CallbackContext obj)
    {
        _pressed = true;
        _pressTimeOut = Time.time + highlgihtTime;
        PressImage.sprite = PressSpriteHighlight;
;
    }

    void OnEnable()
    {
        PressActionRef.action.started += onPressed;
    }
    void OnDisable()
    {
        PressActionRef.action.started -= onPressed;
    }
}
