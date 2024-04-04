using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UIElements;

public class Points : VisualElement
{
    VisualElement point1 = new VisualElement();
    VisualElement point2 = new VisualElement();
    VisualElement point3 = new VisualElement();

    public Points()
    { 
        styleSheets.Add(Resources.Load<StyleSheet>("GogoInfoStyleSheet"));
        point1.AddToClassList("point");
        point2.AddToClassList("point");
        point3.AddToClassList("point");

        hierarchy.Add(point1);
        hierarchy.Add(point2);  
        hierarchy.Add(point3);
    }

    int estado;

    public int Estado
    {
        get => estado;
        set
        {
            estado = value;
            cambiarEstado();
        }
    }

    void cambiarEstado()
    {
        if(estado < 1)
        {
            point1.style.display = DisplayStyle.None;
            point2.style.display = DisplayStyle.None;
            point3.style.display = DisplayStyle.None;
        }
        if(estado == 1)
        {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.None;
            point3.style.display = DisplayStyle.None;
        }
        if(estado == 2)
        {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.Flex;
            point3.style.display = DisplayStyle.None;
        }
        if(estado > 2)
        {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.Flex;
            point3.style.display = DisplayStyle.Flex;
        }
    }
}
