﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using UnityEngine;
using LuaInterface;

public static class LuaBinder
{
	public static void Bind(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		DebuggerWrap.Register(L);
		UITextGradientWrap.Register(L);
		NTGLuaScriptWrap.Register(L);
		NTGLuaScriptExtWrap.Register(L);
		TGNetServiceWrap.Register(L);
		NTGApplicationControllerWrap.Register(L);
		NTGResourceControllerWrap.Register(L);
		NTGEventTriggerProxyWrap.Register(L);
		NTGBattleMemberAttrsWrap.Register(L);
		NTGBattleUnitControllerWrap.Register(L);
		NTGBattlePlayerControllerWrap.Register(L);
		L.BeginModule("System");
		System_DateTimeWrap.Register(L);
		L.RegFunction("Action", System_Action);
		L.RegFunction("ActionSelf", System_Action_Self);
		L.BeginModule("IO");
		System_IO_DirectoryWrap.Register(L);
		System_IO_FileWrap.Register(L);
		L.EndModule();
		L.BeginModule("Collections");
		System_Collections_QueueWrap.Register(L);
		System_Collections_StackWrap.Register(L);
		System_Collections_ArrayListWrap.Register(L);
		L.EndModule();
		L.BeginModule("ComponentModel");
		L.RegFunction("PropertyChangedEventHandler", System_ComponentModel_PropertyChangedEventHandler);
		L.RegFunction("PropertyChangedEventHandlerSelf", System_ComponentModel_PropertyChangedEventHandler_Self);
		L.EndModule();
		L.EndModule();
		L.BeginModule("UnityEngine");
		UnityEngine_CoroutineWrap.Register(L);
		UnityEngine_RectWrap.Register(L);
		UnityEngine_SpriteWrap.Register(L);
		UnityEngine_CanvasWrap.Register(L);
		UnityEngine_CanvasGroupWrap.Register(L);
		UnityEngine_AudioListenerWrap.Register(L);
		UnityEngine_ParticleSystemRendererWrap.Register(L);
		UnityEngine_TrailRendererWrap.Register(L);
		UnityEngine_RectTransformWrap.Register(L);
		UnityEngine_RuntimePlatformWrap.Register(L);
		UnityEngine_RectOffsetWrap.Register(L);
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		UnityEngine_LightWrap.Register(L);
		UnityEngine_RigidbodyWrap.Register(L);
		UnityEngine_CameraWrap.Register(L);
		UnityEngine_AudioSourceWrap.Register(L);
		UnityEngine_BehaviourWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_TrackedReferenceWrap.Register(L);
		UnityEngine_ApplicationWrap.Register(L);
		UnityEngine_PhysicsWrap.Register(L);
		UnityEngine_ColliderWrap.Register(L);
		UnityEngine_TimeWrap.Register(L);
		UnityEngine_TextureWrap.Register(L);
		UnityEngine_Texture2DWrap.Register(L);
		UnityEngine_ShaderWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_WWWWrap.Register(L);
		UnityEngine_ScreenWrap.Register(L);
		UnityEngine_CameraClearFlagsWrap.Register(L);
		UnityEngine_AudioClipWrap.Register(L);
		UnityEngine_AssetBundleWrap.Register(L);
		UnityEngine_ParticleSystemWrap.Register(L);
		UnityEngine_AsyncOperationWrap.Register(L);
		UnityEngine_LightTypeWrap.Register(L);
		UnityEngine_SleepTimeoutWrap.Register(L);
		UnityEngine_AnimatorWrap.Register(L);
		UnityEngine_InputWrap.Register(L);
		UnityEngine_KeyCodeWrap.Register(L);
		UnityEngine_SkinnedMeshRendererWrap.Register(L);
		UnityEngine_SpaceWrap.Register(L);
		UnityEngine_MeshRendererWrap.Register(L);
		UnityEngine_ParticleEmitterWrap.Register(L);
		UnityEngine_ParticleRendererWrap.Register(L);
		UnityEngine_ParticleAnimatorWrap.Register(L);
		UnityEngine_BoxColliderWrap.Register(L);
		UnityEngine_MeshColliderWrap.Register(L);
		UnityEngine_SphereColliderWrap.Register(L);
		UnityEngine_CharacterControllerWrap.Register(L);
		UnityEngine_CapsuleColliderWrap.Register(L);
		UnityEngine_AnimationWrap.Register(L);
		UnityEngine_AnimationClipWrap.Register(L);
		UnityEngine_AnimationStateWrap.Register(L);
		UnityEngine_AnimationBlendModeWrap.Register(L);
		UnityEngine_QueueModeWrap.Register(L);
		UnityEngine_PlayModeWrap.Register(L);
		UnityEngine_WrapModeWrap.Register(L);
		UnityEngine_QualitySettingsWrap.Register(L);
		UnityEngine_RenderSettingsWrap.Register(L);
		UnityEngine_BlendWeightsWrap.Register(L);
		UnityEngine_RenderTextureWrap.Register(L);
		L.BeginModule("UI");
		UnityEngine_UI_ImageWrap.Register(L);
		UnityEngine_UI_SliderWrap.Register(L);
		UnityEngine_UI_ToggleWrap.Register(L);
		UnityEngine_UI_OutlineWrap.Register(L);
		UnityEngine_UI_ShadowWrap.Register(L);
		UnityEngine_UI_ScrollRectWrap.Register(L);
		UnityEngine_UI_ScrollbarWrap.Register(L);
		UnityEngine_UI_LayoutGroupWrap.Register(L);
		UnityEngine_UI_LayoutElementWrap.Register(L);
		UnityEngine_UI_CanvasScalerWrap.Register(L);
		UnityEngine_UI_InputFieldWrap.Register(L);
		UnityEngine_UI_BaseMeshEffectWrap.Register(L);
		UnityEngine_UI_TextWrap.Register(L);
		UnityEngine_UI_GridLayoutGroupWrap.Register(L);
		UnityEngine_UI_HorizontalLayoutGroupWrap.Register(L);
		UnityEngine_UI_GraphicRaycasterWrap.Register(L);
		UnityEngine_UI_ButtonWrap.Register(L);
		UnityEngine_UI_MaskableGraphicWrap.Register(L);
		UnityEngine_UI_GraphicWrap.Register(L);
		UnityEngine_UI_SelectableWrap.Register(L);
		UnityEngine_UI_HorizontalOrVerticalLayoutGroupWrap.Register(L);
		L.BeginModule("InputField");
		L.RegFunction("OnValidateInput", UnityEngine_UI_InputField_OnValidateInput);
		L.RegFunction("OnValidateInputSelf", UnityEngine_UI_InputField_OnValidateInput_Self);
		L.EndModule();
		L.EndModule();
		L.BeginModule("EventSystems");
		UnityEngine_EventSystems_EventTriggerWrap.Register(L);
		UnityEngine_EventSystems_AbstractEventDataWrap.Register(L);
		UnityEngine_EventSystems_BaseRaycasterWrap.Register(L);
		UnityEngine_EventSystems_EventSystemWrap.Register(L);
		UnityEngine_EventSystems_PointerEventDataWrap.Register(L);
		UnityEngine_EventSystems_BaseEventDataWrap.Register(L);
		UnityEngine_EventSystems_UIBehaviourWrap.Register(L);
		L.EndModule();
		L.BeginModule("Experimental");
		L.BeginModule("Director");
		UnityEngine_Experimental_Director_DirectorPlayerWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.BeginModule("SceneManagement");
		UnityEngine_SceneManagement_SceneManagerWrap.Register(L);
		UnityEngine_SceneManagement_LoadSceneModeWrap.Register(L);
		UnityEngine_SceneManagement_SceneWrap.Register(L);
		L.EndModule();
		L.BeginModule("Events");
		L.RegFunction("UnityAction", UnityEngine_Events_UnityAction);
		L.RegFunction("UnityActionSelf", UnityEngine_Events_UnityAction_Self);
		L.RegFunction("UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_LoadSceneMode", UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_LoadSceneMode);
		L.RegFunction("UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_LoadSceneModeSelf", UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_LoadSceneMode_Self);
		L.RegFunction("UnityAction_UnityEngine_SceneManagement_Scene", UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene);
		L.RegFunction("UnityAction_UnityEngine_SceneManagement_SceneSelf", UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_Self);
		L.RegFunction("UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_Scene", UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_Scene);
		L.RegFunction("UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_SceneSelf", UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_Scene_Self);
		L.EndModule();
		L.BeginModule("Canvas");
		L.RegFunction("WillRenderCanvases", UnityEngine_Canvas_WillRenderCanvases);
		L.RegFunction("WillRenderCanvasesSelf", UnityEngine_Canvas_WillRenderCanvases_Self);
		L.EndModule();
		L.BeginModule("RectTransform");
		L.RegFunction("ReapplyDrivenProperties", UnityEngine_RectTransform_ReapplyDrivenProperties);
		L.RegFunction("ReapplyDrivenPropertiesSelf", UnityEngine_RectTransform_ReapplyDrivenProperties_Self);
		L.EndModule();
		L.BeginModule("Camera");
		L.RegFunction("CameraCallback", UnityEngine_Camera_CameraCallback);
		L.RegFunction("CameraCallbackSelf", UnityEngine_Camera_CameraCallback_Self);
		L.EndModule();
		L.BeginModule("Application");
		L.RegFunction("LogCallback", UnityEngine_Application_LogCallback);
		L.RegFunction("LogCallbackSelf", UnityEngine_Application_LogCallback_Self);
		L.RegFunction("AdvertisingIdentifierCallback", UnityEngine_Application_AdvertisingIdentifierCallback);
		L.RegFunction("AdvertisingIdentifierCallbackSelf", UnityEngine_Application_AdvertisingIdentifierCallback_Self);
		L.EndModule();
		L.BeginModule("AudioClip");
		L.RegFunction("PCMReaderCallback", UnityEngine_AudioClip_PCMReaderCallback);
		L.RegFunction("PCMReaderCallbackSelf", UnityEngine_AudioClip_PCMReaderCallback_Self);
		L.RegFunction("PCMSetPositionCallback", UnityEngine_AudioClip_PCMSetPositionCallback);
		L.RegFunction("PCMSetPositionCallbackSelf", UnityEngine_AudioClip_PCMSetPositionCallback_Self);
		L.EndModule();
		L.EndModule();
		L.BeginModule("TGNetService");
		TGNetService_NetRequestWrap.Register(L);
		TGNetService_NetEventWrap.Register(L);
		L.RegFunction("NetEventHanlder", TGNetService_NetEventHanlder);
		L.RegFunction("NetEventHanlderSelf", TGNetService_NetEventHanlder_Self);
		L.EndModule();
		L.BeginModule("NTGResourceController");
		NTGResourceController_AssetLoaderWrap.Register(L);
		L.EndModule();
		L.BeginModule("NTGBattleUIController");
		NTGBattleUIController_BattleUpdateDataWrap.Register(L);
		NTGBattleUIController_BattleUpdateSkillDataWrap.Register(L);
		NTGBattleUIController_BattleUpdatePlayerDataWrap.Register(L);
		NTGBattleUIController_UIBattleInfoItemWrap.Register(L);
		L.EndModule();
		L.BeginModule("NTGBattleUnitController");
		NTGBattleUnitController_UnitBuffWrap.Register(L);
		L.EndModule();
		L.BeginModule("Newtonsoft");
		L.BeginModule("Json");
		L.BeginModule("Linq");
		Newtonsoft_Json_Linq_JObjectWrap.Register(L);
		Newtonsoft_Json_Linq_JContainerWrap.Register(L);
		Newtonsoft_Json_Linq_JTokenWrap.Register(L);
		Newtonsoft_Json_Linq_JPropertyWrap.Register(L);
		Newtonsoft_Json_Linq_JValueWrap.Register(L);
		Newtonsoft_Json_Linq_JArrayWrap.Register(L);
		L.EndModule();
		L.EndModule();
		L.EndModule();
		L.BeginModule("NTGEventTriggerProxy");
		L.RegFunction("PointerEventDelegate", NTGEventTriggerProxy_PointerEventDelegate);
		L.RegFunction("PointerEventDelegateSelf", NTGEventTriggerProxy_PointerEventDelegate_Self);
		L.RegFunction("BaseEventDelegate", NTGEventTriggerProxy_BaseEventDelegate);
		L.RegFunction("BaseEventDelegateSelf", NTGEventTriggerProxy_BaseEventDelegate_Self);
		L.RegFunction("AxisBaseEventDelegate", NTGEventTriggerProxy_AxisBaseEventDelegate);
		L.RegFunction("AxisBaseEventDelegateSelf", NTGEventTriggerProxy_AxisBaseEventDelegate_Self);
		L.EndModule();
		L.EndModule();
		Debugger.Log("Register lua type cost time: {0}", Time.realtimeSinceStartup - t);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.Action), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(System.Action), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_ComponentModel_PropertyChangedEventHandler(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(System.ComponentModel.PropertyChangedEventHandler), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_ComponentModel_PropertyChangedEventHandler_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(System.ComponentModel.PropertyChangedEventHandler), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_UI_InputField_OnValidateInput(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.UI.InputField.OnValidateInput), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_UI_InputField_OnValidateInput_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.UI.InputField.OnValidateInput), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Events.UnityAction), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_LoadSceneMode(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_LoadSceneMode_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode>), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_Scene(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene>), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction_UnityEngine_SceneManagement_Scene_UnityEngine_SceneManagement_Scene_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene>), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Canvas_WillRenderCanvases(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Canvas.WillRenderCanvases), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Canvas_WillRenderCanvases_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Canvas.WillRenderCanvases), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_RectTransform_ReapplyDrivenProperties(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.RectTransform.ReapplyDrivenProperties), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_RectTransform_ReapplyDrivenProperties_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.RectTransform.ReapplyDrivenProperties), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Camera_CameraCallback(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Camera.CameraCallback), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Camera_CameraCallback_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Camera.CameraCallback), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LogCallback(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Application.LogCallback), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_LogCallback_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Application.LogCallback), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_AdvertisingIdentifierCallback(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.Application.AdvertisingIdentifierCallback), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Application_AdvertisingIdentifierCallback_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.Application.AdvertisingIdentifierCallback), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMReaderCallback(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.AudioClip.PCMReaderCallback), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMReaderCallback_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.AudioClip.PCMReaderCallback), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMSetPositionCallback(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_AudioClip_PCMSetPositionCallback_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(UnityEngine.AudioClip.PCMSetPositionCallback), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TGNetService_NetEventHanlder(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(TGNetService.NetEventHanlder), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TGNetService_NetEventHanlder_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(TGNetService.NetEventHanlder), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NTGEventTriggerProxy_PointerEventDelegate(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(NTGEventTriggerProxy.PointerEventDelegate), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NTGEventTriggerProxy_PointerEventDelegate_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(NTGEventTriggerProxy.PointerEventDelegate), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NTGEventTriggerProxy_BaseEventDelegate(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(NTGEventTriggerProxy.BaseEventDelegate), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NTGEventTriggerProxy_BaseEventDelegate_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(NTGEventTriggerProxy.BaseEventDelegate), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NTGEventTriggerProxy_AxisBaseEventDelegate(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			Delegate arg1 = DelegateFactory.CreateDelegate(typeof(NTGEventTriggerProxy.AxisBaseEventDelegate), func);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}



	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NTGEventTriggerProxy_AxisBaseEventDelegate_Self(IntPtr L)
	{
		try
		{
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);
			LuaTable self = ToLua.CheckLuaTable(L, 2);
			Delegate arg1 = DelegateFactory.CreateDelegate_Self(typeof(NTGEventTriggerProxy.AxisBaseEventDelegate), func, self);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

