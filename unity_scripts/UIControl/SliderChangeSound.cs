
//
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine.SearchService;
using System.IO;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    //[AddComponentMenu("Scripts/MRTK/Examples/ShowSliderValue")]
    public class SliderChangeSound : MonoBehaviour
    {
        [SerializeField]
        public GameObject slider;
        AudioSource audioTrack;

        private TextMeshPro textMesh = null;


        public void OnSliderUpdated(SliderEventData eventData)
        {
            Debug.Log("sliding detected"+ eventData.NewValue);
            if (textMesh == null)
            {
                Debug.Log("mesh is null");
                textMesh = GetComponent<TextMeshPro>();
            } else {
                textMesh.text = $"{eventData.NewValue}";
                audioTrack = GetComponent<AudioSource>();
                audioTrack.volume = eventData.NewValue;
                Debug.Log("i think the value isssssss"+ eventData.NewValue);
            }
        }
    }
}




