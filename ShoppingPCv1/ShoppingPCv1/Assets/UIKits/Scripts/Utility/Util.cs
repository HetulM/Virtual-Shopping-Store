﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRUiKits.Utils
{
    public class Util : MonoBehaviour
    {
        public static T SafeDestroy<T>(T obj) where T : Object
        {
            if (Application.isEditor)
                Object.DestroyImmediate(obj);
            else
                Object.Destroy(obj);

            return null;
        }
        public static T SafeDestroyGameObject<T>(T component) where T : Component
        {
            if (component != null)
                SafeDestroy(component.gameObject);
            return null;
        }
        public static void DestroyChildren(Transform root)
        {
            for (int i = root.childCount - 1; i >= 0; i--)
            {
                SafeDestroyGameObject(root.GetChild(i));
            }
        }
    }
}