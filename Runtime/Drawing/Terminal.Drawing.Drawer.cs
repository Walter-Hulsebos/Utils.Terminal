using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utils.Terminal
{
    public static partial class Terminal
    {
        public sealed class GizmoDrawer : MonoBehaviour
        {
            #region Singleton
            
            private static readonly Lazy<GizmoDrawer> lazy_instance = new Lazy<GizmoDrawer>(CreateSingleton);
            public static GizmoDrawer Instance => lazy_instance.Value;

            private static GizmoDrawer CreateSingleton()
            {
                GameObject __owner = new GameObject(); //{ hideFlags = HideFlags.HideInHierarchy };
                DontDestroyOnLoad(__owner);
                
                return __owner.AddComponent<GizmoDrawer>();
            }
            
            #endregion
            
            private readonly List<Gizmo> _gizmos = new List<Gizmo>();

            private void Update()
            {
                foreach (Gizmo __gizmo in _gizmos)
                {
                    __gizmo.durationLeft -= Time.deltaTime;
                }
            }

            private void OnDrawGizmos()
            {
                foreach (Gizmo __gizmo in _gizmos)
                {
                    Color     __prevColor  = Gizmos.color;
                    Matrix4x4 __prevMatrix = Gizmos.matrix;
                    
                    Gizmos.color = __gizmo.color;

                    if (__gizmo.matrix != default)
                    {
                        Gizmos.matrix = __gizmo.matrix;
                    }

                    __gizmo.Invoke();
                    
                    Gizmos.color  = __prevColor;
                    Gizmos.matrix = __prevMatrix;
                }
            }
            
            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Draw(in Gizmo gizmo)
                => Instance._gizmos.Add(gizmo);
            
            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Draw(params Gizmo[] gizmos)
                => Instance._gizmos.AddRange(gizmos);
        }
        
        
        
    }
}
