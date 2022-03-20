using System.Runtime.CompilerServices;

using UnityEngine;

using Unity.Mathematics;

namespace CGTK.Utils.Terminal
{
    using static PackageConstants;
    
    public static partial class Terminal
    {
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawCube(float3 center, float3 size)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawCube(center, size)));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawWireCube(float3 center, float3 size)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawWireCube(center, size)));
            #else
            return null;
            #endif
        }
        
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawFrustum(float3 center, float fov, float maxRange, float minRange, float aspect)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawFrustum(center, fov, maxRange, minRange, aspect)));
            #else
            return null;
            #endif
        }
        
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawGUITexture(Rect screenRect, Texture texture, Material material = null)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawGUITexture(screenRect, texture, material)));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawGUITexture(Rect screenRect, Texture texture, int leftBorder, int rightBorder, int topBorder, int bottomBorder, Material material = null)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawGUITexture(screenRect, texture, leftBorder, rightBorder, topBorder, bottomBorder, material)));
            #else
            return null;
            #endif
        }
        
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawIcon(float3 center, string name, bool allowScaling = true)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawIcon(center, name, allowScaling)));
            #else
            return null;
            #endif
        }
        
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawLine(float3 from, float3 to)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawLine(from, to)));
            #else
            return null;
            #endif
        }
        
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawMesh(Mesh mesh, float3 position)
        {
            #if UNITY_EDITOR
            return DrawMesh(mesh, position, rotation: quaternion.identity, scale: new float3(x: 1f, y: 1f, z: 1f));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawMesh(Mesh mesh, float3 position, quaternion rotation)
        {
            #if UNITY_EDITOR
            return DrawMesh(mesh, position, rotation, scale: new float3(x: 1f, y: 1f, z: 1f));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawMesh(Mesh mesh, float3 position, quaternion rotation, float3 scale)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawMesh(mesh, position, rotation, scale)));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawMesh(Mesh mesh, float3 position, quaternion rotation, float3 scale, int subMeshIndex)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawMesh(mesh, subMeshIndex, position, rotation, scale)));
            #else
            return null;
            #endif
        }
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawWireMesh(Mesh mesh, float3 position)
        {
            #if UNITY_EDITOR
            return DrawMesh(mesh, position, rotation: quaternion.identity, scale: new float3(x: 1f, y: 1f, z: 1f));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawWireMesh(Mesh mesh, float3 position, quaternion rotation)
        {
            #if UNITY_EDITOR
            return DrawMesh(mesh, position, rotation, scale: new float3(x: 1f, y: 1f, z: 1f));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawWireMesh(Mesh mesh, float3 position, quaternion rotation, float3 scale)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawWireMesh(mesh, position, rotation, scale)));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawWireMesh(Mesh mesh, float3 position, quaternion rotation, float3 scale, int subMeshIndex)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawWireMesh(mesh, subMeshIndex, position, rotation, scale)));
            #else
            return null;
            #endif
        }
        
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawRay(float3 origin, float3 direction)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawRay(origin, direction)));
            #else
            return null;
            #endif
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawRay(Ray ray)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawRay(ray)));
            #else
            return null;
            #endif  
        }
        
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawSphere(float3 center, float radius)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawSphere(center, radius)));
            #else
            return null;
            #endif  
        }
        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo DrawWireSphere(float3 center, float radius)
        {
            #if UNITY_EDITOR
            return Draw(new Gizmo(() => Gizmos.DrawWireSphere(center, radius)));
            #else
            return null;
            #endif  
        }
        

        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo Draw(Gizmo gizmo)
        {
            Drawer.Instance.gizmos.Add(gizmo);
            
            return gizmo;
        }

        [MethodImpl(methodImplOptions: INLINE)]
        public static Gizmo[] Draw(params Gizmo[] gizmos)
        {
            Drawer.Instance.gizmos.AddRange(gizmos);

            return gizmos;
        }
        
    }
}
