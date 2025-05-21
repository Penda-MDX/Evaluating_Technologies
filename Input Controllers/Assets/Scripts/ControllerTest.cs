using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class ControllerTest : MonoBehaviour
{

    public Image LTPRessImage;
    public Image RTPRessImage;
    public Image LTMoveImage;
    public Image RTPMoveImage;
    public Image SelectBImage;
    public Image MenuBImage;
    public Image XpressImage;
    public Image YpressImage;
    public Image ApressImage;
    public Image BpressImage;
    public Image LBumperImage; 
    public Image RBumperImage;
    public Image LTriggerImage;
    public Image RTriggerImage;

    public Sprite LTPRessSprite;
    public Sprite RTPRessSprite;
    public Sprite LTMoveSpritee;
    public Sprite RTPMoveSprite;
    public Sprite SelectBSprite;
    public Sprite MenuBSprite;
    public Sprite XpressSprite;
    public Sprite YpressSprite;
    public Sprite ApressSprite;
    public Sprite BpressSprite;
    public Sprite LBumperSprite;
    public Sprite RBumperSprite;
    public Sprite LTriggerSprite;
    public Sprite RTriggerSprite;

    public Sprite HighlightLTPRessSprite;
    public Sprite HighlightRTPRessSprite;
    public Sprite HighlightLTMoveSpritee;
    public Sprite HighlightRTPMoveSprite;
    public Sprite HighlightSelectBSprite;
    public Sprite HighlightMenuBSprite;
    public Sprite HighlightXpressSprite;
    public Sprite HighlightYpressSprite;
    public Sprite HighlightApressSprite;
    public Sprite HighlightBpressSprite;
    public Sprite HighlightLBumperSprite;
    public Sprite HighlightRBumperSprite;
    public Sprite HighlightLTriggerSprite;
    public Sprite HighlightRTriggerSprite;


    public InputActionReference move;
    public InputActionReference fire;

    public InputActionReference LTPRess;
    public InputActionReference RTPRess;
    public InputActionReference LTMove;
    public InputActionReference RTPMove;
    public InputActionReference SelectB;
    public InputActionReference MenuB;
    public InputActionReference Xpress;
    public InputActionReference Ypress;
    public InputActionReference Apress;
    public InputActionReference Bpress;
    public InputActionReference LBumper;
    public InputActionReference RBumper;
    public InputActionReference LTrigger;
    public InputActionReference RTrigger;

    private Vector2 lMove = Vector2.zero;
    private Vector2 rMove = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rMove = RTPMove.action.ReadValue<Vector2>();
        lMove = LTMove.action.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        if (lMove != Vector2.zero)
        {

        }
        if (rMove != Vector2.zero)
        {

        }
    }

    void onLTPress(InputAction.CallbackContext obj)
    {

    }
    void onRTPress(InputAction.CallbackContext obj)
    {

    }
    /*
    void onLTMove()
    {

    }
    void onRTPMove()
    {

    }
    */
    void onSelectB(InputAction.CallbackContext obj)
    {

    }
    void onMenuB(InputAction.CallbackContext obj)
    {

    }
    void onXpress(InputAction.CallbackContext obj)
    {

    }
    void onYpress(InputAction.CallbackContext obj)
    {

    }
    void onApress(InputAction.CallbackContext obj)
    {

    }
    void onBpress(InputAction.CallbackContext obj)
    {

    }
    void onLBumper(InputAction.CallbackContext obj)
    {

    }
    void onRBumper(InputAction.CallbackContext obj)
    {

    }
    void onLTrigger(InputAction.CallbackContext obj)
    {

    }
    void onRTrigger(InputAction.CallbackContext obj)
    {

    }

    // Start is called before the first frame update
    void OnEnable()
    {
        //fire.action.started += OnFire;
        //.action.started +=
        LTPRess.action.started += onLTPress;
        RTPRess.action.started += onRTPress;
        SelectB.action.started += onSelectB;
        MenuB.action.started += onMenuB;
        Xpress.action.started += onXpress;
        Ypress.action.started += onYpress;
        Apress.action.started += onApress;
        Bpress.action.started += onBpress;
        LBumper.action.started += onLBumper;
        RBumper.action.started += onRBumper;
        LTrigger.action.started += onLTrigger;
        RTrigger.action.started += onRTrigger;
    }
    void OnDisable()
    {
        //fire.action.started -= OnFire;
        //.action.started -=
        LTPRess.action.started -= onLTPress;
        RTPRess.action.started -= onRTPress;
        SelectB.action.started -= onSelectB;
        MenuB.action.started -= onMenuB;
        Xpress.action.started -= onXpress;
        Ypress.action.started -= onYpress;
        Apress.action.started -= onApress;
        Bpress.action.started -= onBpress;
        LBumper.action.started -= onLBumper;
        RBumper.action.started -= onRBumper;
        LTrigger.action.started -= onLTrigger;
        RTrigger.action.started -= onRTrigger;

    }
}
