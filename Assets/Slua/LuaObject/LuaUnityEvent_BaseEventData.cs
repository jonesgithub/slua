﻿
using System;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SLua
{
    public class LuaUnityEvent_BaseEventData : LuaObject
    {

        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int AddListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<BaseEventData> self = checkSelf<UnityEngine.Events.UnityEvent<BaseEventData>>(l);
                UnityEngine.Events.UnityAction<BaseEventData> a1;
                checkType(l, 2, out a1);
                self.AddListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int RemoveListener(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<BaseEventData> self = checkSelf<UnityEngine.Events.UnityEvent<BaseEventData>>(l);
                UnityEngine.Events.UnityAction<BaseEventData> a1;
                checkType(l, 2, out a1);
                self.RemoveListener(a1);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static public int Invoke(IntPtr l)
        {
            try
            {
                UnityEngine.Events.UnityEvent<BaseEventData> self = checkSelf<UnityEngine.Events.UnityEvent<BaseEventData>>(l);
                BaseEventData o;
                checkType(l,2,out o);
                self.Invoke(o);
                return 0;
            }
            catch (Exception e)
            {
                LuaDLL.luaL_error(l, e.ToString());
                return 0;
            }
        }
        static public void reg(IntPtr l)
        {
            getTypeTable(l, typeof(LuaUnityEvent_BaseEventData).FullName);
            addMember(l, AddListener);
            addMember(l, RemoveListener);
            addMember(l, Invoke);
            createTypeMetatable(l, typeof(LuaUnityEvent_BaseEventData));
            LuaDLL.lua_pop(l, 1);
        }

        static bool checkType(IntPtr l,int p,out UnityEngine.Events.UnityAction<BaseEventData> ua) {
            LuaDLL.luaL_checktype(l, p, LuaTypes.LUA_TFUNCTION);
            int r = LuaDLL.luaS_checkcallback(l, p);
            ua = (BaseEventData v) =>
            {
                int error = pushTry(l);
                LuaDLL.lua_getref(l, r);
                pushValue(l, v);
                if (LuaDLL.lua_pcall(l, 1, 0, error) != 0)
                {
                    LuaDLL.lua_pop(l, 1); // pop error msg
                }
                LuaDLL.lua_pop(l, 1); // pop error function
            };
            return true;
        }
    }
}
