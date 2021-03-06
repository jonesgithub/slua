﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_MissingReferenceException : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.MissingReferenceException o;
		if(matchType(l,1)){
			o=new UnityEngine.MissingReferenceException();
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String))){
			System.String a1;
			checkType(l,1,out a1);
			o=new UnityEngine.MissingReferenceException(a1);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.String),typeof(System.Exception))){
			System.String a1;
			checkType(l,1,out a1);
			System.Exception a2;
			checkType(l,2,out a2);
			o=new UnityEngine.MissingReferenceException(a1,a2);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.MissingReferenceException");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.MissingReferenceException));
		LuaDLL.lua_pop(l, 1);
	}
}
