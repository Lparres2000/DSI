using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class Sliders : MonoBehaviour
{
    public void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        UQueryBuilder<VisualElement> builder = new(root);

        //List<Slider> sliderList = root.Query<Slider>().ToList();

        //sliderList.ForEach(slider =>
        //{
        //    //Escondemos el agarre y la barrita del slider, que quedan feísimas
        //    VisualElement dragger = root.Q<VisualElement>("unity-dragger");
        //    dragger.style.display = DisplayStyle.None;

        //    VisualElement tracker = root.Q<VisualElement>("unity-tracker");
        //    tracker.style.display = DisplayStyle.None;
        //});

        List<Slider> sliderList = new List<Slider>();


        Slider s0 = root.Q<Slider>("Percentage");
        sliderList.Add(s0);
        Slider s1 = root.Query<Slider>().AtIndex(0);
        sliderList.Add(s1);
        Slider s2 = root.Query<Slider>().AtIndex(1);
        sliderList.Add(s2);
        Slider s3 = root.Query<Slider>().AtIndex(2);
        sliderList.Add(s3);

        sliderList.ForEach(slider =>
        {
            //Escondemos el agarre y la barrita del slider, que quedan feísimas
            VisualElement dragger = slider.Q<VisualElement>("unity-dragger");
            dragger.style.display = DisplayStyle.None;

            VisualElement tracker = slider.Q<VisualElement>("unity-tracker");
            tracker.style.display = DisplayStyle.None;
        });

      

    }

}
