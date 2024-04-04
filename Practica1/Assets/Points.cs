using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.UIElements;
using UnityEditor;

public class Points : VisualElement
{
    public new class UxmlFactory : UxmlFactory<Points, UxmlTraits> { };
    
    public new class UxmlTraits : VisualElement.UxmlTraits
    {
        UxmlIntAttributeDescription myEstado = new UxmlIntAttributeDescription {name = "estado", defaultValue = 0 };

        public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
        {
            base.Init(ve, bag, cc);
            var puntos = ve as Points;
            puntos.Estado = myEstado.GetValueFromBag(bag, cc);
        }
    }

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

        style.flexDirection = FlexDirection.Row;    
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
