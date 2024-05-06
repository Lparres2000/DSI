
using UnityEngine;
using UnityEngine.UIElements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6_namespace
{
    public class Lab6 : MonoBehaviour {
        VisualElement botonCrear;
        Toggle toggleModificar;
        VisualElement contendor_dcha;
        TextField input_nombre;
        TextField input_apellido;
        VisualElement img1;
        VisualElement img2;
        VisualElement img3;
        VisualElement img4;

        Individuo individuoSelec;

        List<Individuo> list_individuos = new List<Individuo>();

        private void OnEnable() {

            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            contendor_dcha = root.Q<VisualElement>("Dcha");
            input_nombre = root.Q<TextField>("InputNombre");
            input_apellido = root.Q<TextField>("InputApellido");
            botonCrear = root.Q<Button>("BotonCrear");
            toggleModificar = root.Q<Toggle>("ToggleModificar");
            img1 = root.Q<VisualElement>("Imagen1");
            img2 = root.Q<VisualElement>("Imagen2");
            img3 = root.Q<VisualElement>("Imagen3");
            img4 = root.Q<VisualElement>("Imagen4");


            contendor_dcha.RegisterCallback<ClickEvent>(SeleccionTarjeta);
            botonCrear.RegisterCallback<ClickEvent>(NuevaTarjeta);
            input_nombre.RegisterCallback<ChangeEvent<String>>(CambioNombre);
            input_apellido.RegisterCallback<ChangeEvent<String>>(CambioApellido);

            img1.RegisterCallback<ClickEvent>(CambioImg1);
            img2.RegisterCallback<ClickEvent>(CambioImg2);
            img3.RegisterCallback<ClickEvent>(CambioImg3);
            img4.RegisterCallback<ClickEvent>(CambioImg4);
        }


        void NuevaTarjeta(ClickEvent evt) {

            if (!toggleModificar.value) {
                VisualTreeAsset plantilla = Resources.Load<VisualTreeAsset>("Tarjeta");
                VisualElement tarjetaPlantilla = plantilla.Instantiate();

                contendor_dcha.Add(tarjetaPlantilla);

                tarjetas_borde_negro();
                tarjeta_borde_blanco(tarjetaPlantilla);
                Individuo individuo = new Individuo(input_nombre.value, input_apellido.value, img1.resolvedStyle.backgroundImage);
                Tarjeta tarjeta = new Tarjeta(tarjetaPlantilla, individuo);
                individuoSelec = individuo;

                list_individuos.Add(individuo);
                //list_individuos.ForEach(elem => {
                //    Debug.Log(elem.Nombre + " " + elem.Apellido);
                //    string jsonIndividuo = JsonUtility.ToJson(elem);
                //    Debug.Log(jsonIndividuo);
                //});
                //string listaToJson = JsonHelperIndividuo.ToJson(list_individuos, true);
                //Debug.Log(listaToJson);

                //List<Individuo> jsonToLista = JsonHelperIndividuo.FromJson<Individuo>(listaToJson);
                //jsonToLista.ForEach(elem => {
                //    Debug.Log(elem.Nombre + " " + elem.Apellido);
                //});
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

            tarjetas_borde_negro();
            tarjeta_borde_blanco(miTarjeta  );
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

        void CambioImg1(ClickEvent e) {

            individuoSelec.Imagen = img1.resolvedStyle.backgroundImage;
        }

        void CambioImg2(ClickEvent e) {
            individuoSelec.Imagen = img2.resolvedStyle.backgroundImage;
        }

        void CambioImg3(ClickEvent e) {
            individuoSelec.Imagen = img3.resolvedStyle.backgroundImage;
        }

        void CambioImg4(ClickEvent e) {
            individuoSelec.Imagen = img4.resolvedStyle.backgroundImage;
        }

        void tarjetas_borde_negro() {
            List<VisualElement> lista_tarjetas = contendor_dcha.Children().ToList();
            lista_tarjetas.ForEach(elem =>
            {
                VisualElement tarjeta = elem.Q("Tarjeta");
                tarjeta.style.borderBottomColor = Color.black;
                tarjeta.style.borderRightColor = Color.black; 
                tarjeta.style.borderTopColor = Color.black; 
                tarjeta.style.borderLeftColor = Color.black;
            });
        }
        void tarjeta_borde_blanco(VisualElement tar) {

            VisualElement tarjeta = tar.Q("Tarjeta");
            tarjeta.style.borderBottomColor = Color.white; 
            tarjeta.style.borderRightColor = Color.white;
            tarjeta.style.borderTopColor = Color.white;
            tarjeta.style.borderLeftColor = Color.white;
        }
    }
}