using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public OVRHand leftHand;
    public OVRHand rightHand;
    public List<GameObject> objectsToDeactivate = new List<GameObject>();

    private bool isGestureDetected = false;

    void Update()
    {
        DetectGesture(leftHand);
        DetectGesture(rightHand);
    }

    void DetectGesture(OVRHand hand)
    {
        // Verifica que los dedos índice y medio estén extendidos
        bool isIndexExtended = hand.GetFingerIsPinching(OVRHand.HandFinger.Index) == false && hand.GetFingerConfidence(OVRHand.HandFinger.Index) == OVRHand.TrackingConfidence.High;
        bool isMiddleExtended = hand.GetFingerIsPinching(OVRHand.HandFinger.Middle) == false && hand.GetFingerConfidence(OVRHand.HandFinger.Middle) == OVRHand.TrackingConfidence.High;

        // Verifica que los otros dedos (pulgar, anular y meñique) estén doblados
        bool isThumbBent = hand.GetFingerIsPinching(OVRHand.HandFinger.Thumb) == true || hand.GetFingerConfidence(OVRHand.HandFinger.Thumb) != OVRHand.TrackingConfidence.High;
        bool isRingBent = hand.GetFingerIsPinching(OVRHand.HandFinger.Ring) == true || hand.GetFingerConfidence(OVRHand.HandFinger.Ring) != OVRHand.TrackingConfidence.High;
        bool isPinkyBent = hand.GetFingerIsPinching(OVRHand.HandFinger.Pinky) == true || hand.GetFingerConfidence(OVRHand.HandFinger.Pinky) != OVRHand.TrackingConfidence.High;

        // Verifica la condición de la pose "V"
        isGestureDetected = isIndexExtended && isMiddleExtended && isThumbBent && isRingBent && isPinkyBent;
        if(isGestureDetected)
        {
            OnGestureDetected();
        }
    }

    void OnGestureDetected()
    {
        foreach (var obj in objectsToDeactivate)
        {
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }
    }
}