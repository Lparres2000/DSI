using UnityEngine.UIElements;
using UnityEngine;

public class AddHearts : VisualElement
{
    public new class UxmlFactory : UxmlFactory<AddHearts, UxmlTraits> { };

    public new class UxmlTraits : VisualElement.UxmlTraits
    {
        UxmlIntAttributeDescription myEstado = new UxmlIntAttributeDescription { name = "NumElems", defaultValue = 0 };
        UxmlIntAttributeDescription type = new UxmlIntAttributeDescription { name = "Type", defaultValue = 0 };
        public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) {
            base.Init(ve, bag, cc);
            var puntos = ve as AddHearts;
            puntos.Estado = myEstado.GetValueFromBag(bag, cc);
            puntos.Type = type.GetValueFromBag(bag, cc);
        }
    }

    VisualElement point1 = new VisualElement();
    VisualElement point2 = new VisualElement();
    VisualElement point3 = new VisualElement();
    VisualElement point4 = new VisualElement();
    VisualElement point5 = new VisualElement();

    public AddHearts() {
        styleSheets.Add(Resources.Load<StyleSheet>("HeartsInfoStyleSheet"));
        point1.AddToClassList("heart");
        point2.AddToClassList("heart");
        point3.AddToClassList("heart");
        point4.AddToClassList("heart");
        point5.AddToClassList("heart");

        hierarchy.Add(point1);
        hierarchy.Add(point2);
        hierarchy.Add(point3);
        hierarchy.Add(point4);
        hierarchy.Add(point5);

        style.flexDirection = FlexDirection.Row;
    }

    int estado;

    public int Estado {
        get => estado;
        set {
            estado = value;
            cambiarEstado();
        }
    }

    int type;

    public int Type {
        get => type;
        set {
            type = value;
            cambiarTipo();
        }
    }

    void cambiarEstado() {
        if (estado < 1) {
            point1.style.display = DisplayStyle.None;
            point2.style.display = DisplayStyle.None;
            point3.style.display = DisplayStyle.None;
            point4.style.display = DisplayStyle.None;
            point5.style.display = DisplayStyle.None;
        }
        if (estado == 1) {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.None;
            point3.style.display = DisplayStyle.None;
            point4.style.display = DisplayStyle.None;
            point5.style.display = DisplayStyle.None;
        }
        if (estado == 2) {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.Flex;
            point3.style.display = DisplayStyle.None;
            point4.style.display = DisplayStyle.None;
            point5.style.display = DisplayStyle.None;
        }
        if (estado == 3) {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.Flex;
            point3.style.display = DisplayStyle.Flex;
            point4.style.display = DisplayStyle.None;
            point5.style.display = DisplayStyle.None;
        }
        if (estado == 4) {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.Flex;
            point3.style.display = DisplayStyle.Flex;
            point4.style.display = DisplayStyle.Flex;
            point5.style.display = DisplayStyle.None;
        }
        if (estado > 4) {
            point1.style.display = DisplayStyle.Flex;
            point2.style.display = DisplayStyle.Flex;
            point3.style.display = DisplayStyle.Flex;
            point4.style.display = DisplayStyle.Flex;
            point5.style.display = DisplayStyle.Flex;
        }
    }

    void cambiarTipo() {
        if(type == 1) {
            point1.ClearClassList();
            point1.AddToClassList("heart");
            point2.ClearClassList();
            point2.AddToClassList("heart");
            point3.ClearClassList();
            point3.AddToClassList("heart");
            point4.ClearClassList();
            point4.AddToClassList("heart");
            point5.ClearClassList();
            point5.AddToClassList("heart");
        }
        if (type == 2) {
            point1.ClearClassList();
            point1.AddToClassList("shield");
            point2.ClearClassList();
            point2.AddToClassList("shield");
            point3.ClearClassList();
            point3.AddToClassList("shield");
            point4.ClearClassList();
            point4.AddToClassList("shield");
            point5.ClearClassList();
            point5.AddToClassList("shield");
        }
        if (type == 3) {
            point1.ClearClassList();
            point1.AddToClassList("mana");
            point2.ClearClassList();
            point2.AddToClassList("mana");
            point3.ClearClassList();
            point3.AddToClassList("mana");
            point4.ClearClassList();
            point4.AddToClassList("mana");
            point5.ClearClassList();
            point5.AddToClassList("mana");
        }
    }
}
