using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    Label textoDinero;
    int dinero = 1000;

    //Para definir la posición hasta donde está relleno el inventario
    int index = 0;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        //Añadimos los huecos del inventario en una lista
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


        textoDinero = root.Q<Label>("MoneyAmount");
        textoDinero.text = dinero.ToString();
    }

    void CompraProducto1(ClickEvent evt)
    {
        if (input_producto1.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto1.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto1.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto1.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto1.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto1.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto1.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto1.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }
    void CompraProducto2(ClickEvent evt)
    {
        if (input_producto2.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto2.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto2.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto2.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto2.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto2.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto2.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto2.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }
    void CompraProducto3(ClickEvent evt)
    {
        if (input_producto3.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto3.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto3.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto3.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto3.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto3.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto3.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto3.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }
    void CompraProducto4(ClickEvent evt)
    {
        if (input_producto4.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto4.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto4.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto4.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto4.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto4.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto4.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto4.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }
    void CompraProducto5(ClickEvent evt)
    {
        if (input_producto5.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto5.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto5.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto5.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto5.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto5.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto5.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto5.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }
    void CompraProducto6(ClickEvent evt)
    {
        if (input_producto6.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto6.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto6.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto6.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto6.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto6.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto6.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto6.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }
    void CompraProducto7(ClickEvent evt)
    {
        if (input_producto7.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto7.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto7.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto7.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto7.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto7.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto7.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto7.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }
    void CompraProducto8(ClickEvent evt)
    {
        if (input_producto8.Q<VisualElement>("Icon").style.opacity != 0.5f &&
            int.Parse(input_producto8.Q<Button>("Button").text) <= dinero)
        {
            StyleBackground productImage = input_producto8.Q<VisualElement>("Icon").resolvedStyle.backgroundImage;
            inventory[index].Q<VisualElement>("Icon").style.backgroundImage = productImage;
            index++;

            //dinero -= int.Parse(input_producto1.Q<Button>("Button").text);
            //textoDinero.text = dinero.ToString();

            //Icono
            input_producto8.Q<VisualElement>("Icon").style.opacity = 0.5f;
            //PriceTag
            input_producto8.Q<VisualElement>("Button").style.backgroundImage = new StyleBackground(Resources.Load<Sprite>("PriceSoldOut"));
            input_producto8.Q<VisualElement>("Button").style.opacity = 0.5f;
            //input_producto8.Q<VisualElement>("Button").style.textOverflow = soldOut;
            //Fondo
            input_producto8.Q<VisualElement>("Product").style.opacity = 0.5f;
        }
        
    }




}
