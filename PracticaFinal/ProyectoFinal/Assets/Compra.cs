using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Compra : MonoBehaviour
{
    //Plantillas donde ponemos los productos
    VisualElement slot1;
    VisualElement slot2;
    VisualElement slot3;
    VisualElement slot4;
    VisualElement slot5;
    VisualElement slot6;
    VisualElement slot7;
    VisualElement slot8;

    VisualElement input_producto1;
    VisualElement input_producto2;
    VisualElement input_producto3;
    VisualElement input_producto4;
    VisualElement input_producto5;
    VisualElement input_producto6;
    VisualElement input_producto7;
    VisualElement input_producto8;

    List<VisualElement> inventory = new List<VisualElement>();

    //Para definir la posici�n hasta donde est� relleno el inventario
    int index = 0;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        //A�adimos los huecos del inventario en una lista
        slot1 = root.Q("Slot1");
        slot2 = root.Q("Slot2");
        slot3 = root.Q("Slot3");
        slot4 = root.Q("Slot4");
        slot5 = root.Q("Slot5");
        slot6 = root.Q("Slot6");
        slot7 = root.Q("Slot7");
        slot8 = root.Q("Slot8");

        inventory.Add(slot1);
        inventory.Add(slot2);
        inventory.Add(slot3);
        inventory.Add(slot4);
        inventory.Add(slot5);
        inventory.Add(slot6);
        inventory.Add(slot7);   
        inventory.Add(slot8);

        input_producto1 = root.Q<VisualElement>("Product1");
        input_producto2 = root.Q<VisualElement>("Product2");
        input_producto3 = root.Q<VisualElement>("Product3");
        input_producto4 = root.Q<VisualElement>("Product4");
        input_producto5 = root.Q<VisualElement>("Product5");
        input_producto6 = root.Q<VisualElement>("Product6");
        input_producto7 = root.Q<VisualElement>("Product7");
        input_producto8 = root.Q<VisualElement>("Product8");

        input_producto1.RegisterCallback<ClickEvent>(CompraProducto1);
        input_producto2.RegisterCallback<ClickEvent>(CompraProducto2);
        input_producto3.RegisterCallback<ClickEvent>(CompraProducto3);
        input_producto4.RegisterCallback<ClickEvent>(CompraProducto4);
        input_producto5.RegisterCallback<ClickEvent>(CompraProducto5);
        input_producto6.RegisterCallback<ClickEvent>(CompraProducto6);
        input_producto7.RegisterCallback<ClickEvent>(CompraProducto7);
        input_producto8.RegisterCallback<ClickEvent>(CompraProducto8);
    }

    void CompraProducto1(ClickEvent evt)
    {
        StyleBackground productImage = input_producto1.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }
    void CompraProducto2(ClickEvent evt)
    {
        StyleBackground productImage = input_producto2.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }
    void CompraProducto3(ClickEvent evt)
    {
        StyleBackground productImage = input_producto3.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }
    void CompraProducto4(ClickEvent evt)
    {
        StyleBackground productImage = input_producto4.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }
    void CompraProducto5(ClickEvent evt)
    {
        StyleBackground productImage = input_producto5.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }
    void CompraProducto6(ClickEvent evt)
    {
        StyleBackground productImage = input_producto6.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }
    void CompraProducto7(ClickEvent evt)
    {
        StyleBackground productImage = input_producto7.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }
    void CompraProducto8(ClickEvent evt)
    {
        StyleBackground productImage = input_producto8.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
        inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
        index++;
    }


}
