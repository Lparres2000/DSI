using UnityEngine.UIElements;
using UnityEngine;

public class Lab5 : MonoBehaviour
{
    VisualElement plantilla1;
    VisualElement plantilla2;
    VisualElement plantilla3;
    VisualElement plantilla4;

    VisualElement plantillaSelected;

    TextField input_nombre;
    TextField input_apellido;

    VisualElement input_gogo1;
    VisualElement input_gogo2;
    VisualElement input_gogo3;
    VisualElement input_gogo4;

    private void OnEnable() {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        plantilla1 = root.Q("plantilla1");
        plantilla2 = root.Q("plantilla2");
        plantilla3 = root.Q("plantilla3");
        plantilla4 = root.Q("plantilla4");

        plantilla1.RegisterCallback<ClickEvent>(SeleccionIndividuo1);
        plantilla2.RegisterCallback<ClickEvent>(SeleccionIndividuo2);
        plantilla3.RegisterCallback<ClickEvent>(SeleccionIndividuo3);
        plantilla4.RegisterCallback<ClickEvent>(SeleccionIndividuo4);

        input_nombre = root.Q<TextField>("inputnombre");
        input_apellido = root.Q<TextField>("inputapellido");
     
        input_nombre.RegisterCallback<ChangeEvent<string>>(CambioNombre);
        input_apellido.RegisterCallback<ChangeEvent<string>>(CambioApellido);

        input_gogo1 = root.Q<VisualElement>("gogo1");
        input_gogo2 = root.Q<VisualElement>("gogo2");
        input_gogo3 = root.Q<VisualElement>("gogo3");
        input_gogo4 = root.Q<VisualElement>("gogo4");

        input_gogo1.RegisterCallback<ClickEvent>(CambioGogo1);
        input_gogo2.RegisterCallback<ClickEvent>(CambioGogo2);
        input_gogo3.RegisterCallback<ClickEvent>(CambioGogo3);
        input_gogo4.RegisterCallback<ClickEvent>(CambioGogo4);
    }   

    void SeleccionIndividuo1(ClickEvent evt) {
        string nombre = plantilla1.Q<Label>("nombre").text;
        string apellido = plantilla1.Q<Label>("apellido").text;

        plantillaSelected = plantilla1;

        input_nombre.SetValueWithoutNotify(nombre);
        input_apellido.SetValueWithoutNotify(apellido);

        SelectedColor();
    }
    void SeleccionIndividuo2(ClickEvent evt) {
        string nombre = plantilla2.Q<Label>("nombre").text;
        string apellido = plantilla2.Q<Label>("apellido").text;

        plantillaSelected = plantilla2;

        input_nombre.SetValueWithoutNotify(nombre);
        input_apellido.SetValueWithoutNotify(apellido);

        SelectedColor();
    }
    void SeleccionIndividuo3(ClickEvent evt) {
        string nombre = plantilla3.Q<Label>("nombre").text;
        string apellido = plantilla3.Q<Label>("apellido").text;

        plantillaSelected = plantilla3;

        input_nombre.SetValueWithoutNotify(nombre);
        input_apellido.SetValueWithoutNotify(apellido);

        SelectedColor();
    }
    void SeleccionIndividuo4(ClickEvent evt) {
        string nombre = plantilla4.Q<Label>("nombre").text;
        string apellido = plantilla4.Q<Label>("apellido").text;

        plantillaSelected = plantilla4;

        input_nombre.SetValueWithoutNotify(nombre);
        input_apellido.SetValueWithoutNotify(apellido);

        SelectedColor();
    }

    void CambioNombre(ChangeEvent<string> evt) {
        Label nombreLabel = plantillaSelected.Q<Label>("nombre");
        nombreLabel.text = evt.newValue;
    }
    void CambioApellido(ChangeEvent<string> evt) {
        Label apellidoLabel = plantillaSelected.Q<Label>("apellido");
        apellidoLabel.text = evt.newValue;
    }

    void CambioGogo1(ClickEvent evt) {
        VisualElement gogoImage = plantillaSelected.Q<VisualElement>("gogoimage");
        gogoImage.style.backgroundImage = input_gogo1.resolvedStyle.backgroundImage;
    }
    void CambioGogo2(ClickEvent evt) {
        VisualElement gogoImage = plantillaSelected.Q<VisualElement>("gogoimage");
        gogoImage.style.backgroundImage = input_gogo2.resolvedStyle.backgroundImage;
    }
    void CambioGogo3(ClickEvent evt) {
        VisualElement gogoImage = plantillaSelected.Q<VisualElement>("gogoimage");
        gogoImage.style.backgroundImage = input_gogo3.resolvedStyle.backgroundImage;
    }
    void CambioGogo4(ClickEvent evt) {
        VisualElement gogoImage = plantillaSelected.Q<VisualElement>("gogoimage");
        gogoImage.style.backgroundImage = input_gogo4.resolvedStyle.backgroundImage;
    }

    void SelectedColor() {
        plantilla1.style.borderBottomColor = Color.black;
        plantilla1.style.borderLeftColor = Color.black;
        plantilla1.style.borderRightColor = Color.black;
        plantilla1.style.borderTopColor = Color.black;

        plantilla2.style.borderBottomColor = Color.black;
        plantilla2.style.borderLeftColor = Color.black;
        plantilla2.style.borderRightColor = Color.black;
        plantilla2.style.borderTopColor = Color.black;

        plantilla3.style.borderBottomColor = Color.black;
        plantilla3.style.borderLeftColor = Color.black;
        plantilla3.style.borderRightColor = Color.black;
        plantilla3.style.borderTopColor = Color.black;

        plantilla4.style.borderBottomColor = Color.black;
        plantilla4.style.borderLeftColor = Color.black;
        plantilla4.style.borderRightColor = Color.black;
        plantilla4.style.borderTopColor = Color.black;

        plantillaSelected.style.borderBottomColor = Color.white;
        plantillaSelected.style.borderLeftColor = Color.white;
        plantillaSelected.style.borderRightColor = Color.white;
        plantillaSelected.style.borderTopColor = Color.white;
    }
}