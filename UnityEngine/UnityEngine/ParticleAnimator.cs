using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	[Obsolete("This component is part of the legacy particle system, which is deprecated and will be removed in a future release. Use the ParticleSystem component instead.", false)]
	public sealed class ParticleAnimator : Component
	{
		public extern bool doesAnimateColor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		public Vector3 worldRotationAxis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_worldRotationAxis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_worldRotationAxis(ref value);
			}
		}

		public Vector3 localRotationAxis
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_localRotationAxis(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_localRotationAxis(ref value);
			}
		}

		public extern float sizeGrow
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		public Vector3 rndForce
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_rndForce(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_rndForce(ref value);
			}
		}

		public Vector3 force
		{
			get
			{
				Vector3 result;
				this.INTERNAL_get_force(out result);
				return result;
			}
			set
			{
				this.INTERNAL_set_force(ref value);
			}
		}

		public extern float damping
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		public extern bool autodestruct
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		public extern Color[] colorAnimation
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldRotationAxis(out Vector3 value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_worldRotationAxis(ref Vector3 value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localRotationAxis(out Vector3 value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localRotationAxis(ref Vector3 value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rndForce(out Vector3 value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rndForce(ref Vector3 value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_force(out Vector3 value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_force(ref Vector3 value);
	}
}
