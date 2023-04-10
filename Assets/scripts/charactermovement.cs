//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/scripts/charactermovement.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Charactermovement: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Charactermovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""charactermovement"",
    ""maps"": [
        {
            ""name"": ""playermovment"",
            ""id"": ""7b99f410-43bb-40ef-bff5-181ae2dc22ae"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""Value"",
                    ""id"": ""12088ee8-1140-4cd2-8069-b98a642a4bfb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""3f5fb494-58c1-4d80-925b-67703461625d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8d83a314-ea9f-4137-96f4-ed92bbbe0fba"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6847527a-1780-4950-9e18-50f7c891b42b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2c42164-0dff-4658-9d99-f2534753ce58"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""46ec5666-a1d2-4c5c-aba9-a0259cb5cca8"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9952b599-f8fc-44be-a801-ae24729f5a36"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40cdf2a5-f905-43b1-940e-7b9afc0fa504"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // playermovment
        m_playermovment = asset.FindActionMap("playermovment", throwIfNotFound: true);
        m_playermovment_movement = m_playermovment.FindAction("movement", throwIfNotFound: true);
        m_playermovment_jump = m_playermovment.FindAction("jump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // playermovment
    private readonly InputActionMap m_playermovment;
    private List<IPlayermovmentActions> m_PlayermovmentActionsCallbackInterfaces = new List<IPlayermovmentActions>();
    private readonly InputAction m_playermovment_movement;
    private readonly InputAction m_playermovment_jump;
    public struct PlayermovmentActions
    {
        private @Charactermovement m_Wrapper;
        public PlayermovmentActions(@Charactermovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_playermovment_movement;
        public InputAction @jump => m_Wrapper.m_playermovment_jump;
        public InputActionMap Get() { return m_Wrapper.m_playermovment; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayermovmentActions set) { return set.Get(); }
        public void AddCallbacks(IPlayermovmentActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayermovmentActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayermovmentActionsCallbackInterfaces.Add(instance);
            @movement.started += instance.OnMovement;
            @movement.performed += instance.OnMovement;
            @movement.canceled += instance.OnMovement;
            @jump.started += instance.OnJump;
            @jump.performed += instance.OnJump;
            @jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPlayermovmentActions instance)
        {
            @movement.started -= instance.OnMovement;
            @movement.performed -= instance.OnMovement;
            @movement.canceled -= instance.OnMovement;
            @jump.started -= instance.OnJump;
            @jump.performed -= instance.OnJump;
            @jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPlayermovmentActions instance)
        {
            if (m_Wrapper.m_PlayermovmentActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayermovmentActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayermovmentActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayermovmentActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayermovmentActions @playermovment => new PlayermovmentActions(this);
    public interface IPlayermovmentActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
