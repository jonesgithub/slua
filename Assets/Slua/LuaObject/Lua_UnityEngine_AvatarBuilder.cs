﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AvatarBuilder : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.AvatarBuilder o;
		if(matchType(l,1)){
			o=new UnityEngine.AvatarBuilder();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BuildHumanAvatar(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			UnityEngine.HumanDescription a2;
			checkType(l,2,out a2);
			UnityEngine.Avatar ret=UnityEngine.AvatarBuilder.BuildHumanAvatar(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BuildGenericAvatar(IntPtr l) {
		try{
			UnityEngine.GameObject a1;
			checkType(l,1,out a1);
			System.String a2;
			checkType(l,2,out a2);
			UnityEngine.Avatar ret=UnityEngine.AvatarBuilder.BuildGenericAvatar(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AvatarBuilder");
		addMember(l,BuildHumanAvatar, "BuildHumanAvatar");
		addMember(l,BuildGenericAvatar, "BuildGenericAvatar");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.AvatarBuilder));
		LuaDLL.lua_pop(l, 1);
	}
}
