using System;
using UnityEngine;

namespace CGTK.Utils.Terminal
{
    public static partial class Terminal
    {
        public sealed class Gizmo
        {
            internal Action action;
            internal Color color;
            internal Matrix4x4 matrix;
            internal float durationLeft;
            internal int creationFrame;

            internal Gizmo(Action action)
            {
                this.action = action;
                this.color = UnityEngine.Color.white;
                this.matrix = Matrix4x4.identity;
                this.durationLeft = 0;
                this.creationFrame = Time.frameCount;
            }

            public bool IsAlive => (durationLeft > 0f);
            public bool IsDead  => (durationLeft <= 0f);

            public Gizmo Color(Color color)
            {
                this.color = color;

                return this;
            }

            public Gizmo Duration(float duration)
            {
                this.durationLeft = duration;

                return this;
            }

            public Gizmo Matrix(Matrix4x4 matrix)
            {
                this.matrix = matrix;

                return this;
            }

            internal void Invoke()
            {
                action?.Invoke();
            }
        }
    }
}
