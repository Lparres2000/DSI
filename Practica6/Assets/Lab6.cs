
using UnityEngine;
using UnityEngine.UIElements;
using System;
using Lab6_namespace;

namespace Lab6_namespace
{
    public class Lab6 : MonoBehaviour
    {
        VisualElement botonCrear;
        Toggle toggleModificar;
        VisualElement contendor_dcha;
        TextField input_nombre;
        TextField input_apellido;
        Individuo individuoSelec;

        private void OnEnable() {
            
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            contendor_dcha = root.Q<VisualElement>("Dcha");
            input_nombre = root.Q<TextField>("InputNombre");
            input_apellido = root.Q<TextField>("InputApellido");
            botonCrear = root.Q<Button>("BotonCrear");
            toggleModificar = root.Q<Toggle>("ToggleModificar");


            contendor_dcha.RegisterCallback<ClickEvent>(SeleccionTarjeta);
            botonCrear.RegisterCallback<ClickEvent>(NuevaTarjeta);
            input_nombre.RegisterCallback<ChangeEvent<String>>(CambioNombre); 
            input_apellido.RegisterCallback<ChangeEvent<String>>(CambioApellido);
        }


        void NuevaTarjeta(ClickEvent evt) {
            if (!toggleModificar.value) {
                VisualTreeAsset plantilla = Resources.Load<VisualTreeAsset>("Tarjeta");
                VisualElement tarjetaPlantilla = plantilla.Instantiate();

                contendor_dcha.Add(tarjetaPlantilla);

                Individuo individuo = new Individuo(input_nombre.value, input_apellido.value);
                Tarjeta tarjeta = new Tarjeta(tarjetaPlantilla, individuo);
                individuoSelec = individuo;
            }
        }

        void SeleccionTarjeta(ClickEvent e) {

            VisualElement miTarjeta = e.target as VisualElement; 
            individuoSelec = miTarjeta.userData as Individuo;
            Debug.Log(miTarjeta);
            Debug.Log(miTarjeta.userData);
            input_nombre.SetValueWithoutNotify(individuoSelec.Nombre);
            input_apellido.SetValueWithoutNotify(individuoSelec.Apellido);
            toggleModificar.value = true;
        }

        void CambioNombre(ChangeEvent<string> evt) {
            if (toggleModificar.value) {
                individuoSelec.Nombre = evt.newValue;
            }
        }
        void CambioApellido(ChangeEvent<string> evt) {
            if (toggleModificar.value) {
                individuoSelec.Apellido = evt.newValue;
            }
        }
    }
}