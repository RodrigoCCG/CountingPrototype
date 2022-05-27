using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSlippy : MonoBehaviour
{
    [SerializeField] Vector3 mousePosition;
    [SerializeField] Vector3 targetPosition;
    [SerializeField] float moveSpeed;
    [SerializeField] Camera mainCam;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        //Move Blender in the game area following the mouse
        int playArea = 30;
        mousePosition = Input.mousePosition;
        mousePosition = mainCam.ScreenToViewportPoint(new Vector2(mousePosition.x,mousePosition.y));
        targetPosition = new Vector3((mousePosition.x*playArea)-playArea/2, transform.position.y, transform.position.z); 
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed);    
    }
}
