using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


/// <summary>
/// IPointerDownHandler - Detects concurrent mouse clicks   
/// Interface to recieve to then process mouse click is the "OnPointerDown" callback function
/// 
/// LINKS:
/// 1.) https://docs.unity3d.com/2018.3/Documentation/ScriptReference/EventSystems.IPointerDownHandler.html
/// 2.) https://docs.unity3d.com/2018.3/Documentation/ScriptReference/EventSystems.IPointerDownHandler.OnPointerDown.html
/// 
/// IPointerUpHandler - Detects release of mouse click (when you release mouse button)
/// Interface to recieve to process release is "OnPointerUp" callback function
/// 
/// LINKS:
/// 1.) https://docs.unity3d.com/2018.3/Documentation/ScriptReference/EventSystems.IPointerUpHandler.html
/// 2.) https://docs.unity3d.com/2018.3/Documentation/ScriptReference/EventSystems.IPointerUpHandler.OnPointerUp.html
/// 
/// </summary>

public class ClickButtonAnimationBehaviour : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _IMG;
    [SerializeField] private Sprite _Default, _Pressed;
    public void OnPointerDown(PointerEventData eventData)
    {
        _IMG.sprite = _Pressed;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _IMG.sprite = _Default;
    }
}
