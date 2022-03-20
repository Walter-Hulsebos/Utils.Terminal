using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;

using UnityEngine;

namespace CGTK.Utils.Terminal
{
    public static partial class Terminal
    {
        public sealed class Drawer : MonoBehaviour
        {
            #region Singleton
            
            private static readonly Lazy<Drawer> lazy_instance = new Lazy<Drawer>(CreateSingleton);
            public static Drawer Instance => lazy_instance.Value;

            private static Drawer CreateSingleton()
            {
                //can't hide it, those don't work with DonDestroyOnLoad for some dumb reason.
                GameObject __owner = new GameObject(name: "[" + nameof(CGTK.Utils.Terminal) + "." + nameof(Drawer) + "]"); //{ hideFlags = HideFlags.HideInHierarchy }; 
                DontDestroyOnLoad(__owner);
                
                return __owner.AddComponent<Drawer>();
            }
            
            #endregion
            
            internal readonly List<Gizmo> gizmos = new List<Gizmo>();

            private void Update()
            {
                foreach (Gizmo __gizmo in gizmos)
                {
                    __gizmo.durationLeft -= Time.deltaTime;
                }
            }

            private void OnDrawGizmos()
            {
                for (int __index = gizmos.Count - 1; __index >= 0; __index--) //reverse for loop so we can delete gizmos once they're dead.
                {
                    Gizmo __gizmo = gizmos[__index]; 
                    
                    __DrawGizmo(__gizmo);
                    
                    if(__gizmo.IsDead)
                    {
                        gizmos.Remove(__gizmo);
                    }
                }

                void __DrawGizmo(Gizmo gizmo)
                {
                    Color     __prevColor  = Gizmos.color;
                    Matrix4x4 __prevMatrix = Gizmos.matrix;
                    
                    Gizmos.color = gizmo.color;

                    if (gizmo.matrix != default)
                    {
                        Gizmos.matrix = gizmo.matrix;
                    }

                    gizmo.Invoke();
                    
                    Gizmos.color  = __prevColor;
                    Gizmos.matrix = __prevMatrix;
                }
            }
            
            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Draw(Gizmo gizmo)
                => Instance.gizmos.Add(gizmo);
            
            [PublicAPI]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Draw(params Gizmo[] gizmos)
                => Instance.gizmos.AddRange(gizmos);
        }
        
        
        
    }
}
