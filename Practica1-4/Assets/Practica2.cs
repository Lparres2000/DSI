using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UIElements;


public class Practica2 : MonoBehaviour
{
    private void OnEnable()
    {
        // Referencia al UIDocument
        UIDocument uiDoc = GetComponent<UIDocument>();

        // Referencia a la raiz del UIDocument
        VisualElement rootVE = uiDoc.rootVisualElement;

        // Creamos una Query de objetos de tipo VisualElement a partir de la raiz
        UQueryBuilder<VisualElement> builder = new(rootVE);

        // Creamos una lista con todos los elementos del Query
        //List<VisualElement> listVE = builder.ToList();
        // Recorremos la lista
        //listVE.ForEach(element => print(element.name));

        // Creamos una lista de Labels que sean de la clase "gogoname". 
        List<Label> listGogonames = rootVE.Query<Label>(className: "gogoname").ToList();

        // Recorremos la lista de labels
        //listGogonames.ForEach(element => print(element.name));

        // Imprimimos por consola el número de gogos, y recorremos la lista para obtener sus nombres
        Debug.Log("Numero de gogos: " + listGogonames.Count);
        Debug.Log("Nombres de los gogos: ");
        listGogonames.ForEach(element => print(element.text));

        // Obtenemos el objecto de la clase "selector".
        VisualElement selector = rootVE.Query(className: "selector");

        // Cambiamos el orden de los elementos de selector.
        selector.style.flexDirection = FlexDirection.RowReverse;

        // Creamos una lista con los fondos de los personajes.
        List<VisualElement> bgPj = rootVE.Query(className: "bgpj").ToList();

        // Eliminamos la imagen asociada al fondo de cada personaje.
        bgPj.ForEach(element => element.style.backgroundImage = null);


        List<VisualElement> gogoBgList = rootVE.Query(className: "bgpj").ToList();
        gogoBgList.ForEach(element => element.Q("Gogo").AddManipulator(new GogoManipulator()));

        Label title = rootVE.Query<Label>(className: "titleText");
        title.text = @"<b><gradient=""Gradiente"">SELECT YOUR GOGO</gradient></b>";

        List<VisualElement> gogoInfo = rootVE.Query<VisualElement>(className: "gogoinfo").ToList();

        List<List<VisualElement>> gogoPoints = new List<List<VisualElement>>();

        foreach(var info in gogoInfo)
        {
            List<VisualElement> points = info.Query<VisualElement>(className: "point").ToList();

            gogoPoints.Add(points);
            int i = Random.Range(0, points.Count);
            //while(i > 0)
            //{
            //    Debug.Log(points.Count);
            //    points[i].style.display = DisplayStyle.None;
            //    points[i].style.unityBackgroundImageTintColor = new Color(255, 255, 0, 0);
            //    i--;
            //}
        }




    }
}
