using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControls : MonoBehaviour
{
    public float moveSpeed;

        [SerializeField]
    private Vector2 moveDirection;

    public InputActionReference move;
    public InputActionReference fire;

    public GameObject bulletObject;

    public GameObject aimpoint;

    private GameObject newBullet;

    // Update is called once per frame
    void Update()
    {
        moveDirection = move.action.ReadValue<Vector2>();
        Debug.Log(moveDirection);
    }

    void FixedUpdate()
    {
        //basic move using translate
        gameObject.transform.Translate(moveDirection.x*moveSpeed*Time.deltaTime, moveDirection.y * moveSpeed * Time.deltaTime, 0 );


    }

    public void OnFire(InputAction.CallbackContext obj)
    {
        //Debug.Log("Fired");
        newBullet = Instantiate(bulletObject, aimpoint.transform.position, Quaternion.identity);
        newBullet.GetComponent<Bullet>().moveDirection = new Vector2(0,1);

    }


    // Start is called before the first frame update
    void OnEnable()
    {
        fire.action.started += OnFire;
    }
    void OnDisable()
    {
        fire.action.started -= OnFire;
    }
}
