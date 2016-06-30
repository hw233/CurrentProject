﻿using System;

public static class LuaBinder
{
	public static void Bind(IntPtr L)
	{
		objectWrap.Register(L);
		ObjectWrap.Register(L);
		TypeWrap.Register(L);
		DelegateWrap.Register(L);
		IEnumeratorWrap.Register(L);
		EnumWrap.Register(L);
		StringWrap.Register(L);
		MsgPacketWrap.Register(L);
		AnimationBlendModeWrap.Register(L);
		AnimationClipWrap.Register(L);
		AnimationStateWrap.Register(L);
		AnimationWrap.Register(L);
		ApplicationWrap.Register(L);
		AssetBundleWrap.Register(L);
		AsyncOperationWrap.Register(L);
		AudioClipWrap.Register(L);
		AudioSourceWrap.Register(L);
		BaseLuaWrap.Register(L);
		BehaviourWrap.Register(L);
		BlendWeightsWrap.Register(L);
		BoxColliderWrap.Register(L);
		ByteBufferWrap.Register(L);
		CameraClearFlagsWrap.Register(L);
		CameraWrap.Register(L);
		CharacterControllerWrap.Register(L);
		ColliderWrap.Register(L);
		ComponentWrap.Register(L);
		ConstWrap.Register(L);
		GameObjectWrap.Register(L);
		GlobalWrap.Register(L);
		InputWrap.Register(L);
		iooWrap.Register(L);
		KeyCodeWrap.Register(L);
		LightTypeWrap.Register(L);
		LightWrap.Register(L);
		LuaHelperWrap.Register(L);
		MaterialWrap.Register(L);
		MeshColliderWrap.Register(L);
		MeshRendererWrap.Register(L);
		MonoBehaviourWrap.Register(L);
		NetworkManagerWrap.Register(L);
		PanelManagerWrap.Register(L);
		ParticleAnimatorWrap.Register(L);
		ParticleEmitterWrap.Register(L);
		ParticleRendererWrap.Register(L);
		ParticleSystemWrap.Register(L);
		PhysicsWrap.Register(L);
		PlaneWrap.Register(L);
		PlayModeWrap.Register(L);
		PrimitiveTypeWrap.Register(L);
		QualitySettingsWrap.Register(L);
		QueueModeWrap.Register(L);
		RectTransformWrap.Register(L);
		RendererWrap.Register(L);
		RenderSettingsWrap.Register(L);
		RenderTextureWrap.Register(L);
		ResourceManagerWrap.Register(L);
		ScreenWrap.Register(L);
		SkinnedMeshRendererWrap.Register(L);
		SleepTimeoutWrap.Register(L);
		SpaceWrap.Register(L);
		SphereColliderWrap.Register(L);
		TextWrap.Register(L);
		TimerManagerWrap.Register(L);
		TimeWrap.Register(L);
		TouchPhaseWrap.Register(L);
		TrackedReferenceWrap.Register(L);
		TransformWrap.Register(L);
		UtilWrap.Register(L);
	}
}
