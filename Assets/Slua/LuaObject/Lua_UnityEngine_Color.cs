﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Color : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		LuaDLL.lua_remove(l,1);
		UnityEngine.Color o;
		if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			System.Single a4;
			checkType(l,4,out a4);
			o=new UnityEngine.Color(a1,a2,a3,a4);
			pushObject(l,o);
			return 1;
		}
		else if(matchType(l,1,typeof(System.Single),typeof(System.Single),typeof(System.Single))){
			System.Single a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			o=new UnityEngine.Color(a1,a2,a3);
			pushObject(l,o);
			return 1;
		}
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Lerp(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			UnityEngine.Color ret=UnityEngine.Color.Lerp(a1,a2,a3);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Addition(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			UnityEngine.Color ret=a1+a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Subtraction(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			UnityEngine.Color ret=a1-a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Multiply(IntPtr l) {
		try{
			if(matchType(l,1,typeof(UnityEngine.Color),typeof(UnityEngine.Color))){
				UnityEngine.Color a1;
				checkType(l,1,out a1);
				UnityEngine.Color a2;
				checkType(l,2,out a2);
				UnityEngine.Color ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(UnityEngine.Color),typeof(System.Single))){
				UnityEngine.Color a1;
				checkType(l,1,out a1);
				System.Single a2;
				checkType(l,2,out a2);
				UnityEngine.Color ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,1,typeof(System.Single),typeof(UnityEngine.Color))){
				System.Single a1;
				checkType(l,1,out a1);
				UnityEngine.Color a2;
				checkType(l,2,out a2);
				UnityEngine.Color ret=a1*a2;
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Division(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			UnityEngine.Color ret=a1/a2;
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try{
			UnityEngine.Color a1;
			checkType(l,1,out a1);
			UnityEngine.Color a2;
			checkType(l,2,out a2);
			System.Boolean ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_r(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		pushValue(l,o.r);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_r(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		System.Single v;
		checkType(l,2,out v);
		o.r=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_g(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		pushValue(l,o.g);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_g(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		System.Single v;
		checkType(l,2,out v);
		o.g=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_b(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		pushValue(l,o.b);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_b(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		System.Single v;
		checkType(l,2,out v);
		o.b=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_a(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		pushValue(l,o.a);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_a(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		System.Single v;
		checkType(l,2,out v);
		o.a=v;
		setBack(l,o);
		return 0;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_red(IntPtr l) {
		pushValue(l,UnityEngine.Color.red);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_green(IntPtr l) {
		pushValue(l,UnityEngine.Color.green);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_blue(IntPtr l) {
		pushValue(l,UnityEngine.Color.blue);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_white(IntPtr l) {
		pushValue(l,UnityEngine.Color.white);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_black(IntPtr l) {
		pushValue(l,UnityEngine.Color.black);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_yellow(IntPtr l) {
		pushValue(l,UnityEngine.Color.yellow);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cyan(IntPtr l) {
		pushValue(l,UnityEngine.Color.cyan);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_magenta(IntPtr l) {
		pushValue(l,UnityEngine.Color.magenta);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gray(IntPtr l) {
		pushValue(l,UnityEngine.Color.gray);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grey(IntPtr l) {
		pushValue(l,UnityEngine.Color.grey);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clear(IntPtr l) {
		pushValue(l,UnityEngine.Color.clear);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_grayscale(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		pushValue(l,o.grayscale);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linear(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		pushValue(l,o.linear);
		return 1;
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gamma(IntPtr l) {
		UnityEngine.Color o = checkSelf<UnityEngine.Color>(l);
		pushValue(l,o.gamma);
		return 1;
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Color");
		addMember(l,Lerp, "Lerp");
		addMember(l,op_Addition, "op_Addition");
		addMember(l,op_Subtraction, "op_Subtraction");
		addMember(l,op_Multiply, "op_Multiply");
		addMember(l,op_Division, "op_Division");
		addMember(l,op_Equality, "op_Equality");
		addMember(l,op_Inequality, "op_Inequality");
		addMember(l,get_r, "get_r");
		addMember(l,set_r, "set_r");
		addMember(l,get_g, "get_g");
		addMember(l,set_g, "set_g");
		addMember(l,get_b, "get_b");
		addMember(l,set_b, "set_b");
		addMember(l,get_a, "get_a");
		addMember(l,set_a, "set_a");
		addMember(l,get_red, "get_red");
		addMember(l,get_green, "get_green");
		addMember(l,get_blue, "get_blue");
		addMember(l,get_white, "get_white");
		addMember(l,get_black, "get_black");
		addMember(l,get_yellow, "get_yellow");
		addMember(l,get_cyan, "get_cyan");
		addMember(l,get_magenta, "get_magenta");
		addMember(l,get_gray, "get_gray");
		addMember(l,get_grey, "get_grey");
		addMember(l,get_clear, "get_clear");
		addMember(l,get_grayscale, "get_grayscale");
		addMember(l,get_linear, "get_linear");
		addMember(l,get_gamma, "get_gamma");
		newType(l, constructor);
		createTypeMetatable(l, typeof(UnityEngine.Color));
		LuaDLL.lua_pop(l, 1);
	}
}
