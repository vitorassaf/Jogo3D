// GENERATED AUTOMATICALLY FROM 'Assets/inputnew/InputSystemManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystemManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemManager"",
    ""maps"": [
        {
            ""name"": ""Jogador"",
            ""id"": ""38b39872-e6c1-43bf-9f3a-02ba6cf89b42"",
            ""actions"": [
                {
                    ""name"": ""Movimento"",
                    ""type"": ""Value"",
                    ""id"": ""b7a443a4-11fb-414e-9404-3d9792fe5407"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""88b339c0-1169-40c9-99d3-ff492c8fdeb3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Directions"",
                    ""id"": ""78c5095c-acab-491e-a935-bd915ed666ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c8726032-7eaf-43e3-a349-08e929cbaea5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d0d8ad14-2093-44a7-8abd-6ca09218726c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""659e83f8-29d1-4f2a-93cc-a8e6afabf738"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c3bba9e2-0dee-4e63-967d-22b04a53dce7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DirectionsOthers"",
                    ""id"": ""9486e4dc-7d15-4a37-a087-2bfe2bbe1560"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""19b5fa23-bf12-45ea-99c1-dc0fadd430dc"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""091921b3-ac6f-477e-874f-2f9f35e00457"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""565759d1-055b-4495-a368-87421c2bb4dc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e8c851fa-8364-4b83-ba1b-aa6f1d286d0a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f169a1cd-ada4-4ec7-8950-65be514baec1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Jogador
        m_Jogador = asset.FindActionMap("Jogador", throwIfNotFound: true);
        m_Jogador_Movimento = m_Jogador.FindAction("Movimento", throwIfNotFound: true);
        m_Jogador_Jump = m_Jogador.FindAction("Jump", throwIfNotFound: true);
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

    // Jogador
    private readonly InputActionMap m_Jogador;
    private IJogadorActions m_JogadorActionsCallbackInterface;
    private readonly InputAction m_Jogador_Movimento;
    private readonly InputAction m_Jogador_Jump;
    public struct JogadorActions
    {
        private @InputSystemManager m_Wrapper;
        public JogadorActions(@InputSystemManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimento => m_Wrapper.m_Jogador_Movimento;
        public InputAction @Jump => m_Wrapper.m_Jogador_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Jogador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JogadorActions set) { return set.Get(); }
        public void SetCallbacks(IJogadorActions instance)
        {
            if (m_Wrapper.m_JogadorActionsCallbackInterface != null)
            {
                @Movimento.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Jump.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_JogadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimento.started += instance.OnMovimento;
                @Movimento.performed += instance.OnMovimento;
                @Movimento.canceled += instance.OnMovimento;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public JogadorActions @Jogador => new JogadorActions(this);
    public interface IJogadorActions
    {
        void OnMovimento(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
