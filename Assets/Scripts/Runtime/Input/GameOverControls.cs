//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Runtime/Input/GameOverControls.inputactions
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

public partial class @GameOverControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameOverControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameOverControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""dd99f131-9b99-4bda-830e-e7b186eedf41"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4b02cb89-94ea-4d58-859a-34300ddb5b09"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""25bf3ffe-6aee-458f-84f8-65c0d8c7462c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""be7b3ab5-89a9-4470-88eb-cfe77b258e98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cc8cce14-e67c-4f3a-bd36-7d81b200e962"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9382b306-bb74-4e3a-a7b2-a9c6e48e8dc7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0802d62f-0a3e-4546-9437-d24265331894"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3f36ea06-cbd6-4a87-a538-ed89c4218e73"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""7497aac6-a747-4862-a7fb-f879e47d01ea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ba2678b3-9833-4007-8a03-291cb555768d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9b7ed1c5-7dce-4abf-8f6c-e8a54970f2cd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2df9ec13-72fc-4ee1-b5a2-c1a185d27248"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f248ea6f-1567-4560-9bca-a0566010e28e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c81c9497-8243-46b8-bd33-bb1c4bfa7d7b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""4ccb16dc-2858-4c95-994a-7a186d11a07f"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f01a3396-0f2b-4dee-aec0-7bdd644662b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GameSetting"",
                    ""type"": ""Button"",
                    ""id"": ""1d0fe5c3-eb98-487a-898d-7436f0744739"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DialogueInput"",
                    ""type"": ""Button"",
                    ""id"": ""93e0dfbc-0634-41f8-bec9-212c9c4cc0da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Cheat"",
                    ""type"": ""Button"",
                    ""id"": ""f9f39aac-8b20-422f-92cc-4d6f00dd9adf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""902dda69-5e06-40d2-b28f-47833e8cc4b7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5926c339-de06-491c-b93c-f7b2556b7ee5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GameSetting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16945959-4bf4-4dab-a1bf-9f801be100b7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DialogueInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a862329c-06f5-48c2-ae50-593397d923d1"",
                    ""path"": ""<Keyboard>/f8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cheat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Interaction = m_Player.FindAction("Interaction", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_GameSetting = m_UI.FindAction("GameSetting", throwIfNotFound: true);
        m_UI_DialogueInput = m_UI.FindAction("DialogueInput", throwIfNotFound: true);
        m_UI_Cheat = m_UI.FindAction("Cheat", throwIfNotFound: true);
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Interaction;
    public struct PlayerActions
    {
        private @GameOverControls m_Wrapper;
        public PlayerActions(@GameOverControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Interaction => m_Wrapper.m_Player_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_GameSetting;
    private readonly InputAction m_UI_DialogueInput;
    private readonly InputAction m_UI_Cheat;
    public struct UIActions
    {
        private @GameOverControls m_Wrapper;
        public UIActions(@GameOverControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @GameSetting => m_Wrapper.m_UI_GameSetting;
        public InputAction @DialogueInput => m_Wrapper.m_UI_DialogueInput;
        public InputAction @Cheat => m_Wrapper.m_UI_Cheat;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
            @GameSetting.started += instance.OnGameSetting;
            @GameSetting.performed += instance.OnGameSetting;
            @GameSetting.canceled += instance.OnGameSetting;
            @DialogueInput.started += instance.OnDialogueInput;
            @DialogueInput.performed += instance.OnDialogueInput;
            @DialogueInput.canceled += instance.OnDialogueInput;
            @Cheat.started += instance.OnCheat;
            @Cheat.performed += instance.OnCheat;
            @Cheat.canceled += instance.OnCheat;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
            @GameSetting.started -= instance.OnGameSetting;
            @GameSetting.performed -= instance.OnGameSetting;
            @GameSetting.canceled -= instance.OnGameSetting;
            @DialogueInput.started -= instance.OnDialogueInput;
            @DialogueInput.performed -= instance.OnDialogueInput;
            @DialogueInput.canceled -= instance.OnDialogueInput;
            @Cheat.started -= instance.OnCheat;
            @Cheat.performed -= instance.OnCheat;
            @Cheat.canceled -= instance.OnCheat;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnGameSetting(InputAction.CallbackContext context);
        void OnDialogueInput(InputAction.CallbackContext context);
        void OnCheat(InputAction.CallbackContext context);
    }
}
