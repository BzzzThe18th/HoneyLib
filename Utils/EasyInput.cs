using UnityEngine.XR;
using UnityEngine;

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
        
        public static void UpdateInput()
        {
            InputDevice leftController = InputDevices.GetDeviceAtXRNode(lNode);
            InputDevice rightController = InputDevices.GetDeviceAtXRNode(rNode);

            leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out FaceButtonX);
            leftController.TryGetFeatureValue(CommonUsages.primaryButton, out FaceButtonY);
            rightController.TryGetFeatureValue(CommonUsages.secondaryButton, out FaceButtonA);
            rightController.TryGetFeatureValue(CommonUsages.primaryButton, out FaceButtonB);
            leftController.TryGetFeatureValue(CommonUsages.triggerButton, out LeftTrigger);
            leftController.TryGetFeatureValue(CommonUsages.gripButton, out LeftGrip);
            rightController.TryGetFeatureValue(CommonUsages.triggerButton, out RightTrigger);
            rightController.TryGetFeatureValue(CommonUsages.gripButton, out RightGrip);
            leftController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out LeftStickClick);
            leftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out LeftStick);
            rightController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out RightStickClick);
        }
    }
}
