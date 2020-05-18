using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    // find the empty gameObject containing the hand position for hte hammer
    public static Transform findChildInParent(Transform parent, string childName) {

        foreach (Transform childTransform in parent.GetComponentsInChildren<Transform>()) {

            if (childTransform.gameObject.name == childName) {

                return childTransform;
            }
        }

        return null;
    }
}
