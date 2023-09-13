using UnityEngine.XR;
using UnityEngine;
using HarmonyLib;

namespace HoneyLib.Utils
{
    public static class EasyInput
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

        //oxr
        static bool _FaceButtonX;
        static bool _FaceButtonY;
        static bool _FaceButtonA;
        static bool _FaceButtonB;
        static bool _LeftTrigger;
        static bool _LeftGrip;
        static bool _RightTrigger;
        static bool _RightGrip;
        static bool _LeftStickClick;
        static Vector2 _LeftStick;
        static bool _RightStickClick;
        static Vector2 _RightStick;
        
        public static void UpdateInput()
        {
            InputDevice leftController = InputDevices.GetDeviceAtXRNode(lNode);
            InputDevice rightController = InputDevices.GetDeviceAtXRNode(rNode);

            leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out _FaceButtonX);
            leftController.TryGetFeatureValue(CommonUsages.primaryButton, out _FaceButtonY);
            rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out _FaceButtonA);
            rightController.TryGetFeatureValue(CommonUsages.primaryButton, out _FaceButtonB);
            leftController.TryGetFeatureValue(CommonUsages.triggerButton, out _LeftTrigger);
            leftController.TryGetFeatureValue(CommonUsages.gripButton, out _LeftGrip);
            rightController.TryGetFeatureValue(CommonUsages.triggerButton, out _RightTrigger);
            rightController.TryGetFeatureValue(CommonUsages.gripButton, out _RightGrip);
            leftController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out _LeftStickClick);
            leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out _LeftStick);
            rightController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out _RightStickClick);
            rightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out _RightStick);

            FaceButtonX = ControllerInputPoller.instance?.leftControllerPrimaryButton == true | _FaceButtonX;
            FaceButtonY = ControllerInputPoller.instance?.leftControllerSecondaryButton == true | _FaceButtonY;
            FaceButtonA = ControllerInputPoller.instance?.rightControllerPrimaryButton == true | _FaceButtonA;
            FaceButtonB = ControllerInputPoller.instance?.rightControllerSecondaryButton == true | _FaceButtonB;
            LeftTrigger = ControllerInputPoller.instance?.leftControllerIndexFloat > 0.5f | _LeftTrigger;
            LeftGrip = ControllerInputPoller.instance?.leftControllerGripFloat > 0.5f | _LeftGrip;
            RightTrigger = ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f | _RightTrigger;
            RightGrip = ControllerInputPoller.instance.rightControllerGripFloat > 0.5f | _RightGrip;
            //I do not know of any way to get stick clicks through controller input poller, or other methods, when using steamvr

            //get platform for stick differentiation
            var isSteam = (string)Traverse.Create(GorillaNetworking.PlayFabAuthenticator.instance).Field("platform").GetValue() == "Steam";

            LeftStickClick = _LeftStickClick;
            LeftStick = isSteam ? ControllerInputPoller.Primary2DAxis(lNode) : _LeftStick;
            RightStickClick = _RightStickClick;
            RightStick = isSteam ? ControllerInputPoller.Primary2DAxis(rNode) : _RightStick;
    }
    }
}
