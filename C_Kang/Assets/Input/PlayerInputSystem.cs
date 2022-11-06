//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerInputSystem.inputactions
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

public partial class @PlayerInputSystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""aef8a209-a40c-41f5-9e28-467005b1d1d6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""e1fb24d6-ef6e-4c6b-b170-24c517b103cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dive"",
                    ""type"": ""Button"",
                    ""id"": ""038a5ebc-4984-4740-9e96-39ae669dae96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""99ffdfb1-09cb-46e1-a8f0-b9368135f808"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Q_Skill"",
                    ""type"": ""Button"",
                    ""id"": ""5dd8fd4d-e308-4df9-8432-b90bc71cc16e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""W_Skill"",
                    ""type"": ""Button"",
                    ""id"": ""647e63af-a33c-4754-8fdc-264523c5a673"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""E_Skill"",
                    ""type"": ""Button"",
                    ""id"": ""ea03b499-256e-43ba-b3e9-66120d66a063"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R_Skill"",
                    ""type"": ""Button"",
                    ""id"": ""ad16bea2-bcd5-4014-b66e-e63d59b83070"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pickup"",
                    ""type"": ""Button"",
                    ""id"": ""77104357-9eaf-4c8b-af4f-1cb2a038496b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b58cb260-21be-4c11-b16a-1fca664c3eca"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3be86d8-f251-42c2-8d28-7fc41b12a1ec"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Dive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ee6bc2d-6c74-443f-98fc-c82b528f665d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""def6f793-83e0-45d4-ae72-8465dad75bc7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""Q_Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5127ea4-ca4b-45cd-a7fc-3fa96de44bce"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""W_Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e047b236-16ea-43b9-b357-0d66a6d50767"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""E_Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2df2688e-f27e-4ca9-ad95-5f7ab2173c50"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KM"",
                    ""action"": ""R_Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""087e067a-b5a3-46f3-b326-37b1244db5c4"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pickup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KM"",
            ""bindingGroup"": ""KM"",
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
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Dive = m_Player.FindAction("Dive", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_Q_Skill = m_Player.FindAction("Q_Skill", throwIfNotFound: true);
        m_Player_W_Skill = m_Player.FindAction("W_Skill", throwIfNotFound: true);
        m_Player_E_Skill = m_Player.FindAction("E_Skill", throwIfNotFound: true);
        m_Player_R_Skill = m_Player.FindAction("R_Skill", throwIfNotFound: true);
        m_Player_Pickup = m_Player.FindAction("Pickup", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Dive;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_Q_Skill;
    private readonly InputAction m_Player_W_Skill;
    private readonly InputAction m_Player_E_Skill;
    private readonly InputAction m_Player_R_Skill;
    private readonly InputAction m_Player_Pickup;
    public struct PlayerActions
    {
        private @PlayerInputSystem m_Wrapper;
        public PlayerActions(@PlayerInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Dive => m_Wrapper.m_Player_Dive;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @Q_Skill => m_Wrapper.m_Player_Q_Skill;
        public InputAction @W_Skill => m_Wrapper.m_Player_W_Skill;
        public InputAction @E_Skill => m_Wrapper.m_Player_E_Skill;
        public InputAction @R_Skill => m_Wrapper.m_Player_R_Skill;
        public InputAction @Pickup => m_Wrapper.m_Player_Pickup;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Dive.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDive;
                @Dive.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDive;
                @Dive.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDive;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Q_Skill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_Skill;
                @Q_Skill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_Skill;
                @Q_Skill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQ_Skill;
                @W_Skill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW_Skill;
                @W_Skill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW_Skill;
                @W_Skill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnW_Skill;
                @E_Skill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnE_Skill;
                @E_Skill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnE_Skill;
                @E_Skill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnE_Skill;
                @R_Skill.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR_Skill;
                @R_Skill.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR_Skill;
                @R_Skill.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnR_Skill;
                @Pickup.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
                @Pickup.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPickup;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Dive.started += instance.OnDive;
                @Dive.performed += instance.OnDive;
                @Dive.canceled += instance.OnDive;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Q_Skill.started += instance.OnQ_Skill;
                @Q_Skill.performed += instance.OnQ_Skill;
                @Q_Skill.canceled += instance.OnQ_Skill;
                @W_Skill.started += instance.OnW_Skill;
                @W_Skill.performed += instance.OnW_Skill;
                @W_Skill.canceled += instance.OnW_Skill;
                @E_Skill.started += instance.OnE_Skill;
                @E_Skill.performed += instance.OnE_Skill;
                @E_Skill.canceled += instance.OnE_Skill;
                @R_Skill.started += instance.OnR_Skill;
                @R_Skill.performed += instance.OnR_Skill;
                @R_Skill.canceled += instance.OnR_Skill;
                @Pickup.started += instance.OnPickup;
                @Pickup.performed += instance.OnPickup;
                @Pickup.canceled += instance.OnPickup;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get
        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("KM");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnDive(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnQ_Skill(InputAction.CallbackContext context);
        void OnW_Skill(InputAction.CallbackContext context);
        void OnE_Skill(InputAction.CallbackContext context);
        void OnR_Skill(InputAction.CallbackContext context);
        void OnPickup(InputAction.CallbackContext context);
    }
}
