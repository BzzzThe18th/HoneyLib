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
        public static bool RightStickClick;
        public static Vector2 RightStick;
        public string platform { get; internal set; }
        
        [Obsolete("Input updating manually is now obselete for performance reasons. REMOVE THIS METHOD INVOCATION FROM YOUR CODE")]
        public static void UpdateInput()
        {
        }

        void FixedUpdate()
        {
            var isSteam = platform == "Steam";

            switch (isSteam)
            {
                case true:
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
            
        }
    }
}
