﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_Scrollbar_ScrollEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.UI.Scrollbar.ScrollEvent o;
		if(matchType(l,1)){
			o=new UnityEngine.UI.Scrollbar.ScrollEvent();
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_Single.reg(l);
		getTypeTable(l,"UnityEngine.UI.Scrollbar.ScrollEvent");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.UI.Scrollbar.ScrollEvent));
		LuaDLL.lua_pop(l, 1);
	}
}
