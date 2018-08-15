﻿using UnityEngine;

namespace StandardAssets.Characters.ThirdPerson
{
	[CreateAssetMenu(fileName = "Third Person Animation Configuration", menuName = "Standard Assets/Characters/Third Person Animation Configuration", order = 1)]
	public class ThirdPersonAnimationConfiguration : ScriptableObject
	{
		[SerializeField]
		protected AnimationFloatParameter forwardSpeedParameter = new AnimationFloatParameter("ForwardSpeed", 0.05f, 0.15f);
		
		[SerializeField]
		protected AnimationFloatParameter lateralSpeedParameter = new AnimationFloatParameter("LateralSpeed", 0.01f, 0.05f);

		[SerializeField]
		protected AnimationFloatParameter turningSpeedParameter = new AnimationFloatParameter("TurningSpeed", 0.01f, 0.05f);
		
		[SerializeField]
		protected string verticalSpeedParameter = "VerticalSpeed";
		
		[SerializeField]
		protected string groundedParameter = "Grounded";
		
		[SerializeField]
		protected string hasInputParameter = "HasInput";
		
		[SerializeField]
		protected string fallingTimeParameter = "FallTime";
		
		[SerializeField]
		protected string footednessParameter = "OnRightFoot";
		
		[SerializeField]
		protected string jumpedLateralSpeedParameter = "JumpedLateralSpeed";
		
		[SerializeField]
		protected string jumpedForwardSpeedParameter = "JumpedForwardSpeed";

		[SerializeField]
		protected string predictedFallDistanceParameter = "PredictedFallDistance";
		
		[SerializeField]
		protected string rapidTurnParameter = "RapidTurn";

		[SerializeField]
		protected bool invertFootedness;

		[SerializeField]
		protected float footednessThreshold = 0.25f, footednessThresholdOffset = 0.25f;

		[SerializeField]
		protected float headLookAtWeight = 1f;

		[SerializeField]
		protected float headLookAtMaxRotation = 60f;

		[SerializeField]
		protected float headLookAtRotationSpeed = 90f;

		[Header("Jump Transitions")]
		[SerializeField]
		protected float jumpTransitionDuration = 0.15f;

		[SerializeField]
		protected float rightFootPhysicsJumpLandAnimationTimeOffset = 0.1f,
		                leftFootPhysicsJumpLandAnimationTimeOffset = 0.6f;
		[SerializeField]
		protected AnimationCurve jumpEndTransitionDurationByForwardSpeed = AnimationCurve.Linear(0,0,1,0.125f);
		
		[SerializeField]
		protected float skipJumpLandWindow = 0.25f;

		public AnimationFloatParameter forwardSpeed
		{
			get { return forwardSpeedParameter; }
		}

		public AnimationFloatParameter lateralSpeed
		{
			get { return lateralSpeedParameter; }
		}

		public AnimationFloatParameter turningSpeed
		{
			get { return turningSpeedParameter; }
		}

		public string verticalSpeedParameterName
		{
			get { return verticalSpeedParameter; }
		}

		public string groundedParameterName
		{
			get { return groundedParameter; }
		}

		public string hasInputParameterName
		{
			get { return hasInputParameter; }
		}

		public string fallingTimeParameterName
		{
			get { return fallingTimeParameter; }
		}

		public string footednessParameterName
		{
			get { return footednessParameter; }
		}

		public string jumpedLateralSpeedParameterName
		{
			get { return jumpedLateralSpeedParameter; }
		}

		public string jumpedForwardSpeedParameterName
		{
			get { return jumpedForwardSpeedParameter; }
		}

		public string predictedFallDistanceParameterName
		{
			get { return predictedFallDistanceParameter; }
		}

		public string rapidTurnParameterName
		{
			get { return rapidTurnParameter; }
		}

		public bool invertFoot
		{
			get { return invertFootedness; }
		}

		public float footednessThresholdValue
		{
			get { return footednessThreshold; }
		}

		public float footednessThresholdOffsetValue
		{
			get { return footednessThresholdOffset; }
		}

		public float lookAtWeight
		{
			get { return headLookAtWeight; }
		}

		public float lookAtMaxRotation
		{
			get { return headLookAtMaxRotation; }
		}

		public float lookAtRotationSpeed
		{
			get { return headLookAtRotationSpeed; }
		}

		public AnimationCurve jumpTransitionDurationByForwardSpeed
		{
			get { return jumpEndTransitionDurationByForwardSpeed; }
		}

		public float jumpTransitionTime
		{
			get { return jumpTransitionDuration; }
		}

		public float rightFootPhysicsJumpLandAnimationOffset
		{
			get { return rightFootPhysicsJumpLandAnimationTimeOffset; }
		}

		public float leftFootPhysicsJumpLandAnimationOffset
		{
			get { return leftFootPhysicsJumpLandAnimationTimeOffset; }
		}
		
		public float skipJumpWindow
		{
			get { return skipJumpLandWindow; }
		}
	}
}