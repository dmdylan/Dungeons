// GENERATED AUTOMATICALLY FROM 'Assets/MultiplayerForReal.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MultiplayerForReal : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MultiplayerForReal()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MultiplayerForReal"",
    ""maps"": [
        {
            ""name"": ""InCombat"",
            ""id"": ""e9bcb277-6255-4fcd-b974-28e48ab19e2c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""faf50ccb-175e-4f11-b0a4-5a8550590b98"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""249e817a-bade-4901-bfc6-ae596b8008a3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f4f33678-4e5d-4c0d-8b53-2fe1dd18c3ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BaseAttackOne"",
                    ""type"": ""Button"",
                    ""id"": ""d29c29a0-1839-45ef-9e11-c70b4b5113e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""BaseAttackTwo"",
                    ""type"": ""Button"",
                    ""id"": ""a670a208-84ff-473c-8600-86a93c4b2277"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""098193af-c277-4b49-9876-23d78b18dfa5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""00ca640b-d935-4593-8157-c05846ea39b3"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e2062cb9-1b15-46a2-838c-2f8d72a0bdd9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""320bffee-a40b-4347-ac70-c210eb8bc73a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2581a9b-1d11-4566-b27d-b92aff5fabbc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fcfe95b8-67b9-4526-84b5-5d0bc98d6400"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eae2adea-b3de-44de-ab3d-ab674cd5cfe1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76673cc6-c27c-4ca5-811f-b4555344ba49"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0241ae5-f3e4-442a-93ad-6534078d7f40"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BaseAttackOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe1bb541-6cd1-4d2a-ad67-cf59c6d71c91"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BaseAttackTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12986bf5-2eea-4cf6-8c11-1a5caf0c74f2"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OutOfCombat"",
            ""id"": ""56c46d6a-8e58-4947-87a8-2ddd38a8be7f"",
            ""actions"": [],
            ""bindings"": []
        },
        {
            ""name"": ""InMenu"",
            ""id"": ""dd141c9b-2a4a-4074-b548-4eff6ff3dc4d"",
            ""actions"": [],
            ""bindings"": []
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // InCombat
        m_InCombat = asset.FindActionMap("InCombat", throwIfNotFound: true);
        m_InCombat_Move = m_InCombat.FindAction("Move", throwIfNotFound: true);
        m_InCombat_MousePosition = m_InCombat.FindAction("MousePosition", throwIfNotFound: true);
        m_InCombat_Jump = m_InCombat.FindAction("Jump", throwIfNotFound: true);
        m_InCombat_BaseAttackOne = m_InCombat.FindAction("BaseAttackOne", throwIfNotFound: true);
        m_InCombat_BaseAttackTwo = m_InCombat.FindAction("BaseAttackTwo", throwIfNotFound: true);
        m_InCombat_Dodge = m_InCombat.FindAction("Dodge", throwIfNotFound: true);
        // OutOfCombat
        m_OutOfCombat = asset.FindActionMap("OutOfCombat", throwIfNotFound: true);
        // InMenu
        m_InMenu = asset.FindActionMap("InMenu", throwIfNotFound: true);
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

    // InCombat
    private readonly InputActionMap m_InCombat;
    private IInCombatActions m_InCombatActionsCallbackInterface;
    private readonly InputAction m_InCombat_Move;
    private readonly InputAction m_InCombat_MousePosition;
    private readonly InputAction m_InCombat_Jump;
    private readonly InputAction m_InCombat_BaseAttackOne;
    private readonly InputAction m_InCombat_BaseAttackTwo;
    private readonly InputAction m_InCombat_Dodge;
    public struct InCombatActions
    {
        private @MultiplayerForReal m_Wrapper;
        public InCombatActions(@MultiplayerForReal wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_InCombat_Move;
        public InputAction @MousePosition => m_Wrapper.m_InCombat_MousePosition;
        public InputAction @Jump => m_Wrapper.m_InCombat_Jump;
        public InputAction @BaseAttackOne => m_Wrapper.m_InCombat_BaseAttackOne;
        public InputAction @BaseAttackTwo => m_Wrapper.m_InCombat_BaseAttackTwo;
        public InputAction @Dodge => m_Wrapper.m_InCombat_Dodge;
        public InputActionMap Get() { return m_Wrapper.m_InCombat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InCombatActions set) { return set.Get(); }
        public void SetCallbacks(IInCombatActions instance)
        {
            if (m_Wrapper.m_InCombatActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InCombatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InCombatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InCombatActionsCallbackInterface.OnMove;
                @MousePosition.started -= m_Wrapper.m_InCombatActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_InCombatActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_InCombatActionsCallbackInterface.OnMousePosition;
                @Jump.started -= m_Wrapper.m_InCombatActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_InCombatActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_InCombatActionsCallbackInterface.OnJump;
                @BaseAttackOne.started -= m_Wrapper.m_InCombatActionsCallbackInterface.OnBaseAttackOne;
                @BaseAttackOne.performed -= m_Wrapper.m_InCombatActionsCallbackInterface.OnBaseAttackOne;
                @BaseAttackOne.canceled -= m_Wrapper.m_InCombatActionsCallbackInterface.OnBaseAttackOne;
                @BaseAttackTwo.started -= m_Wrapper.m_InCombatActionsCallbackInterface.OnBaseAttackTwo;
                @BaseAttackTwo.performed -= m_Wrapper.m_InCombatActionsCallbackInterface.OnBaseAttackTwo;
                @BaseAttackTwo.canceled -= m_Wrapper.m_InCombatActionsCallbackInterface.OnBaseAttackTwo;
                @Dodge.started -= m_Wrapper.m_InCombatActionsCallbackInterface.OnDodge;
                @Dodge.performed -= m_Wrapper.m_InCombatActionsCallbackInterface.OnDodge;
                @Dodge.canceled -= m_Wrapper.m_InCombatActionsCallbackInterface.OnDodge;
            }
            m_Wrapper.m_InCombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @BaseAttackOne.started += instance.OnBaseAttackOne;
                @BaseAttackOne.performed += instance.OnBaseAttackOne;
                @BaseAttackOne.canceled += instance.OnBaseAttackOne;
                @BaseAttackTwo.started += instance.OnBaseAttackTwo;
                @BaseAttackTwo.performed += instance.OnBaseAttackTwo;
                @BaseAttackTwo.canceled += instance.OnBaseAttackTwo;
                @Dodge.started += instance.OnDodge;
                @Dodge.performed += instance.OnDodge;
                @Dodge.canceled += instance.OnDodge;
            }
        }
    }
    public InCombatActions @InCombat => new InCombatActions(this);

    // OutOfCombat
    private readonly InputActionMap m_OutOfCombat;
    private IOutOfCombatActions m_OutOfCombatActionsCallbackInterface;
    public struct OutOfCombatActions
    {
        private @MultiplayerForReal m_Wrapper;
        public OutOfCombatActions(@MultiplayerForReal wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_OutOfCombat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OutOfCombatActions set) { return set.Get(); }
        public void SetCallbacks(IOutOfCombatActions instance)
        {
            if (m_Wrapper.m_OutOfCombatActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_OutOfCombatActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public OutOfCombatActions @OutOfCombat => new OutOfCombatActions(this);

    // InMenu
    private readonly InputActionMap m_InMenu;
    private IInMenuActions m_InMenuActionsCallbackInterface;
    public struct InMenuActions
    {
        private @MultiplayerForReal m_Wrapper;
        public InMenuActions(@MultiplayerForReal wrapper) { m_Wrapper = wrapper; }
        public InputActionMap Get() { return m_Wrapper.m_InMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InMenuActions set) { return set.Get(); }
        public void SetCallbacks(IInMenuActions instance)
        {
            if (m_Wrapper.m_InMenuActionsCallbackInterface != null)
            {
            }
            m_Wrapper.m_InMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
            }
        }
    }
    public InMenuActions @InMenu => new InMenuActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IInCombatActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBaseAttackOne(InputAction.CallbackContext context);
        void OnBaseAttackTwo(InputAction.CallbackContext context);
        void OnDodge(InputAction.CallbackContext context);
    }
    public interface IOutOfCombatActions
    {
    }
    public interface IInMenuActions
    {
    }
}
