﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderBuffer");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.RenderBuffer));
		LuaDLL.lua_pop(l, 1);
	}
}
