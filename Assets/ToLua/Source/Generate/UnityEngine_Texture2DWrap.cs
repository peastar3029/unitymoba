﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_Texture2DWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.Texture2D), typeof(UnityEngine.Texture));
		L.RegFunction("CreateExternalTexture", CreateExternalTexture);
		L.RegFunction("UpdateExternalTexture", UpdateExternalTexture);
		L.RegFunction("SetPixel", SetPixel);
		L.RegFunction("GetPixel", GetPixel);
		L.RegFunction("GetPixelBilinear", GetPixelBilinear);
		L.RegFunction("SetPixels", SetPixels);
		L.RegFunction("SetPixels32", SetPixels32);
		L.RegFunction("LoadImage", LoadImage);
		L.RegFunction("LoadRawTextureData", LoadRawTextureData);
		L.RegFunction("GetRawTextureData", GetRawTextureData);
		L.RegFunction("GetPixels", GetPixels);
		L.RegFunction("GetPixels32", GetPixels32);
		L.RegFunction("Apply", Apply);
		L.RegFunction("Resize", Resize);
		L.RegFunction("Compress", Compress);
		L.RegFunction("PackTextures", PackTextures);
		L.RegFunction("ReadPixels", ReadPixels);
		L.RegFunction("EncodeToPNG", EncodeToPNG);
		L.RegFunction("EncodeToJPG", EncodeToJPG);
		L.RegFunction("New", _CreateUnityEngine_Texture2D);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("mipmapCount", get_mipmapCount, null);
		L.RegVar("format", get_format, null);
		L.RegVar("whiteTexture", get_whiteTexture, null);
		L.RegVar("blackTexture", get_blackTexture, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_Texture2D(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.Texture2D obj = new UnityEngine.Texture2D(arg0, arg1);
				ToLua.Push(L, obj);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(int), typeof(int), typeof(UnityEngine.TextureFormat), typeof(bool)))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.TextureFormat arg2 = (UnityEngine.TextureFormat)ToLua.CheckObject(L, 3, typeof(UnityEngine.TextureFormat));
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				UnityEngine.Texture2D obj = new UnityEngine.Texture2D(arg0, arg1, arg2, arg3);
				ToLua.Push(L, obj);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(int), typeof(int), typeof(UnityEngine.TextureFormat), typeof(bool), typeof(bool)))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.TextureFormat arg2 = (UnityEngine.TextureFormat)ToLua.CheckObject(L, 3, typeof(UnityEngine.TextureFormat));
				bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
				UnityEngine.Texture2D obj = new UnityEngine.Texture2D(arg0, arg1, arg2, arg3, arg4);
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.Texture2D.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CreateExternalTexture(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.TextureFormat arg2 = (UnityEngine.TextureFormat)ToLua.CheckObject(L, 3, typeof(UnityEngine.TextureFormat));
			bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
			bool arg4 = LuaDLL.luaL_checkboolean(L, 5);
			System.IntPtr arg5 = (System.IntPtr)LuaDLL.lua_touserdata(L, 6);
			UnityEngine.Texture2D o = UnityEngine.Texture2D.CreateExternalTexture(arg0, arg1, arg2, arg3, arg4, arg5);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateExternalTexture(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			System.IntPtr arg0 = (System.IntPtr)LuaDLL.lua_touserdata(L, 2);
			obj.UpdateExternalTexture(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Color arg2 = ToLua.ToColor(L, 4);
			obj.SetPixel(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Color o = obj.GetPixel(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixelBilinear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Color o = obj.GetPixelBilinear(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixels(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Color[])))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Color[] arg0 = ToLua.CheckObjectArray<UnityEngine.Color>(L, 2);
				obj.SetPixels(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Color[]), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Color[] arg0 = ToLua.CheckObjectArray<UnityEngine.Color>(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.SetPixels(arg0, arg1);
				return 0;
			}
			else if (count == 6 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int), typeof(int), typeof(int), typeof(UnityEngine.Color[])))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				UnityEngine.Color[] arg4 = ToLua.CheckObjectArray<UnityEngine.Color>(L, 6);
				obj.SetPixels(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else if (count == 7 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int), typeof(int), typeof(int), typeof(UnityEngine.Color[]), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				UnityEngine.Color[] arg4 = ToLua.CheckObjectArray<UnityEngine.Color>(L, 6);
				int arg5 = (int)LuaDLL.lua_tonumber(L, 7);
				obj.SetPixels(arg0, arg1, arg2, arg3, arg4, arg5);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.SetPixels");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPixels32(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Color32[])))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Color32[] arg0 = ToLua.CheckObjectArray<UnityEngine.Color32>(L, 2);
				obj.SetPixels32(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Color32[]), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Color32[] arg0 = ToLua.CheckObjectArray<UnityEngine.Color32>(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.SetPixels32(arg0, arg1);
				return 0;
			}
			else if (count == 6 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int), typeof(int), typeof(int), typeof(UnityEngine.Color32[])))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				UnityEngine.Color32[] arg4 = ToLua.CheckObjectArray<UnityEngine.Color32>(L, 6);
				obj.SetPixels32(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else if (count == 7 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int), typeof(int), typeof(int), typeof(UnityEngine.Color32[]), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				UnityEngine.Color32[] arg4 = ToLua.CheckObjectArray<UnityEngine.Color32>(L, 6);
				int arg5 = (int)LuaDLL.lua_tonumber(L, 7);
				obj.SetPixels32(arg0, arg1, arg2, arg3, arg4, arg5);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.SetPixels32");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadImage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(byte[])))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				bool o = obj.LoadImage(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(byte[]), typeof(bool)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				bool o = obj.LoadImage(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.LoadImage");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadRawTextureData(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(byte[])))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				byte[] arg0 = ToLua.CheckByteBuffer(L, 2);
				obj.LoadRawTextureData(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(System.IntPtr), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				System.IntPtr arg0 = (System.IntPtr)LuaDLL.lua_touserdata(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.LoadRawTextureData(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.LoadRawTextureData");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRawTextureData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			byte[] o = obj.GetRawTextureData();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixels(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Color[] o = obj.GetPixels();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Color[] o = obj.GetPixels(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int), typeof(int), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				UnityEngine.Color[] o = obj.GetPixels(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 6 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int arg3 = (int)LuaDLL.lua_tonumber(L, 5);
				int arg4 = (int)LuaDLL.lua_tonumber(L, 6);
				UnityEngine.Color[] o = obj.GetPixels(arg0, arg1, arg2, arg3, arg4);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.GetPixels");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPixels32(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Color32[] o = obj.GetPixels32();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				UnityEngine.Color32[] o = obj.GetPixels32(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.GetPixels32");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				obj.Apply();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(bool)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				obj.Apply(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(bool), typeof(bool)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				obj.Apply(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.Apply");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Resize(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				bool o = obj.Reinitialize(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int), typeof(int), typeof(UnityEngine.TextureFormat), typeof(bool)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.TextureFormat arg2 = (UnityEngine.TextureFormat)ToLua.ToObject(L, 4);
				bool arg3 = LuaDLL.lua_toboolean(L, 5);
				bool o = obj.Reinitialize(arg0, arg1, arg2, arg3);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.Resize");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Compress(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Compress(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PackTextures(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Texture2D[]), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Texture2D[] arg0 = ToLua.CheckObjectArray<UnityEngine.Texture2D>(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				UnityEngine.Rect[] o = obj.PackTextures(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Texture2D[]), typeof(int), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Texture2D[] arg0 = ToLua.CheckObjectArray<UnityEngine.Texture2D>(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				UnityEngine.Rect[] o = obj.PackTextures(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Texture2D[]), typeof(int), typeof(int), typeof(bool)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Texture2D[] arg0 = ToLua.CheckObjectArray<UnityEngine.Texture2D>(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				bool arg3 = LuaDLL.lua_toboolean(L, 5);
				UnityEngine.Rect[] o = obj.PackTextures(arg0, arg1, arg2, arg3);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.PackTextures");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReadPixels(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(int), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Rect arg0 = (UnityEngine.Rect)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.ReadPixels(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(UnityEngine.Rect), typeof(int), typeof(int), typeof(bool)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				UnityEngine.Rect arg0 = (UnityEngine.Rect)ToLua.ToObject(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				bool arg3 = LuaDLL.lua_toboolean(L, 5);
				obj.ReadPixels(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.ReadPixels");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EncodeToPNG(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			byte[] o = obj.EncodeToPNG();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EncodeToJPG(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				byte[] o = obj.EncodeToJPG();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Texture2D), typeof(int)))
			{
				UnityEngine.Texture2D obj = (UnityEngine.Texture2D)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				byte[] o = obj.EncodeToJPG(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.Texture2D.EncodeToJPG");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mipmapCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)o;
			int ret = obj.mipmapCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mipmapCount on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_format(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.Texture2D obj = (UnityEngine.Texture2D)o;
			UnityEngine.TextureFormat ret = obj.format;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index format on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_whiteTexture(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Texture2D.whiteTexture);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_blackTexture(IntPtr L)
	{
		try
		{
			ToLua.Push(L, UnityEngine.Texture2D.blackTexture);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

