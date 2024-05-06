
using UnityEngine;
using UnityEngine.UIElements;

namespace Lab6_namespace
{

    public class Tarjeta
    {

        Individuo miIndividuo;

        VisualElement tarjetaRoot;

        Label nombreLabel;

        Label apellidoLabel;

        VisualElement image;

        public Tarjeta(VisualElement tarjetaRoot, Individuo individuo) {
            this.tarjetaRoot = tarjetaRoot;
            this.miIndividuo = individuo;
            
            nombreLabel = tarjetaRoot.Q<Label>("Nombre");
            apellidoLabel = tarjetaRoot.Q<Label>("Apellido");
            image = tarjetaRoot.Q<VisualElement>("Imagen");
            tarjetaRoot.userData = miIndividuo;
            UpdateUI();

            miIndividuo.Cambio += UpdateUI;
        }



        void UpdateUI() {

            nombreLabel.text = miIndividuo.Nombre;
            apellidoLabel.text = miIndividuo.Apellido;
            image.style.backgroundImage = miIndividuo.Imagen;
            Debug.Log(image.style.backgroundImage);
        }
    }
}