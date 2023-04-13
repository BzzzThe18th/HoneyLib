### EasyInput
EasyInput can be used as simply as running the `UpdateInput` method when you want to check for inputs and then referencing those inputs with simple variables such as `FaceButtonX`

Example:
```cs
        void FixedUpdate()
        {
            EasyInput.UpdateInput();

            if (EasyInput.RightStickClick) Debug.Log("O.O");
        }
```

The result of this snippet would be logging `O.O` when the right stick is being pressed in.

[Back to TOC](https://github.com/BzzzThe18th/HoneyLib/blob/main/Docs/Utils/GeneralUtils/TOC.md)
