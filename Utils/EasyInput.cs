using UnityEngine.XR;
using UnityEngine;
using Valve.VR;
using System;

namespace HoneyLib.Utils
{
    public class EasyInput : MonoBehaviour
    {
        private static XRNode lNode = XRNode.LeftHand;
        private static XRNode rNode = XRNode.RightHand;

        public static bool FaceButtonX;
        public static bool FaceButtonY;
        public static bool FaceButtonA;
        public static bool FaceButtonB;
        public static bool LeftTrigger;
        public static bool LeftGrip;
        public static bool RightTrigger;
        public static bool RightGrip;
        public static bool LeftStickClick;
        public static Vector2 LeftStick;
        public static Vector3 LeftVelocity;
        public static Vector3 LeftPosLocal;
        public static Vector3 LeftPos;
        public static Quaternion LeftRot;
        public static bool RightStickClick;
        public static Vector2 RightStick;
        public static Vector3 RightVelocity;
        public static Vector3 RightPosLocal;
        public static Vector3 RightPos;
        public static Quaternion RightRot;

        public static string platform { get; internal set; }
        
        [Obsolete("Input updating manually is now obselete for performance reasons. REMOVE THIS METHOD INVOCATION FROM YOUR CODE")]
        public static void UpdateInput() { return; }

        void FixedUpdate()
        {
            // auth changed recently, "STEAM" for SteamVR, "OCULUS PC" for oculus rift (link), "OCULUS" for oculus quest
            switch (platform.Contains("STEAM"))
            {
                case true:
                    // SteamVR
                    FaceButtonX = ControllerInputPoller.instance.leftControllerPrimaryButton;
                    FaceButtonY = ControllerInputPoller.instance.leftControllerSecondaryButton;
                    FaceButtonA = ControllerInputPoller.instance.rightControllerPrimaryButton;
                    FaceButtonB = ControllerInputPoller.instance.rightControllerSecondaryButton;
                    LeftTrigger = ControllerInputPoller.instance.leftControllerIndexFloat > 0.5f;
                    LeftGrip = ControllerInputPoller.instance.leftControllerGripFloat > 0.5f;
                    RightTrigger = ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f;
                    RightGrip = ControllerInputPoller.instance.rightControllerGripFloat > 0.5f;
                    LeftStickClick = SteamVR_Actions.gorillaTag_LeftJoystickClick.state;
                    LeftStick = SteamVR_Actions.gorillaTag_LeftJoystick2DAxis.axis;
                    RightStickClick = SteamVR_Actions.gorillaTag_RightJoystickClick.state;
                    RightStick = ControllerInputPoller.instance.rightControllerPrimary2DAxis;
                    break;
                case false:
                    // Oculus Rift
                    InputDevice lC = InputDevices.GetDeviceAtXRNode(lNode);
                    InputDevice rC = InputDevices.GetDeviceAtXRNode(rNode);

                    FaceButtonX = ControllerInputPoller.instance.leftControllerPrimaryButton;
                    FaceButtonY = ControllerInputPoller.instance.leftControllerSecondaryButton;
                    FaceButtonA = ControllerInputPoller.instance.rightControllerPrimaryButton;
                    FaceButtonB = ControllerInputPoller.instance.rightControllerSecondaryButton;
                    LeftTrigger = ControllerInputPoller.instance.leftControllerIndexFloat > 0.5f;
                    LeftGrip = ControllerInputPoller.instance.leftControllerGripFloat > 0.5f;
                    RightTrigger = ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f;
                    RightGrip = ControllerInputPoller.instance.rightControllerGripFloat > 0.5f;
                    lC.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out LeftStickClick);
                    LeftStick = ControllerInputPoller.Primary2DAxis(lNode);
                    rC.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out RightStickClick);
                    RightStick = ControllerInputPoller.Primary2DAxis(rNode);
                    break;
            }
            
            LeftVelocity = GorillaLocomotion.Player.Instance.leftHandCenterVelocityTracker.GetLatestVelocity();
            LeftPosLocal = GorillaLocomotion.Player.Instance.leftControllerTransform.localPosition;
            LeftPos = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
            LeftRot = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
            RightVelocity = GorillaLocomotion.Player.Instance.rightHandCenterVelocityTracker.GetLatestVelocity();
            RightPosLocal = GorillaLocomotion.Player.Instance.rightControllerTransform.localPosition;
            RightPos = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
            RightRot = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
        }
    }
}
