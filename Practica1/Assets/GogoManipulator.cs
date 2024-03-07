using UnityEngine;
using UnityEngine.UIElements;

public class GogoManipulator : Manipulator
{
    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<MouseOverEvent>(OnMouseOver);
        target.RegisterCallback<MouseOutEvent>(OnMouseOut);
        target.RegisterCallback<MouseDownEvent>(OnMouseDown);
    }

    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<MouseOverEvent>(OnMouseOver);
        target.UnregisterCallback<MouseOutEvent>(OnMouseOut);
        target.UnregisterCallback<MouseDownEvent>(OnMouseDown);
    }

    private void OnMouseOver(MouseOverEvent ev)
    {
        target.style.scale = new Scale(Vector2.one * 1.2f);
    }
    
    private void OnMouseOut(MouseOutEvent ev)
    {
        target.style.scale = new Scale(Vector2.one);
    }

    private void OnMouseDown(MouseDownEvent ev)
    {
        target.style.unityBackgroundImageTintColor = new Color(0, 0,0,0);
    }
}

