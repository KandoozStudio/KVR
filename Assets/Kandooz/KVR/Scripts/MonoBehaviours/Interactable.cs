﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kandooz.KVR
{
    [System.Serializable]
    public struct SerializedTransform
    {
        public Vector3 position;
        public Vector3 rotation;
    }
    public enum GrabbingButton
    {
        Trigger ,
        Grip
    }
    public class Interactable : MonoBehaviour
    {
        public HandData handData;
        public GrabbingButton interactionButton;

        [Header("Events")]
        public HandEvent onHandHoverStart;
        public HandEvent onHandHoverEnd;
        public HandEvent onInteractionStart;
        public HandEvent onInteractionEnd;
        [Header("Right Hand properties")]
        [HideInInspector] public HandConstrains rightHandLimits;
        [HideInInspector] public SerializedTransform rightHandPivot;

        [Header("Left Hand properties")]
        [HideInInspector] public HandConstrains leftHandLimits;
        [HideInInspector] public SerializedTransform leftHandPivot;

        public bool InterActedWith { get; set; }

        public void OnHandHoverStart(Hand hand)
        {
            onHandHoverStart.Invoke(hand);
        }
        public void OnHandHoverEnd(Hand hand)
        {
            onHandHoverEnd.Invoke(hand);
        }
        public void OnInteractionStart(Hand hand)
        {
            onInteractionStart.Invoke(hand);
        }
        public void OnInterActionEnd(Hand hand)
        {
            onInteractionEnd.Invoke(hand);
        }
    }
}