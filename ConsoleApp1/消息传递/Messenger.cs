using System;
using System.Collections.Generic;
using System.Collections;
namespace 消息传递
{
    public delegate void Callback();
    public delegate void Callback<T>(T arg0);

    public enum EGameEvent
    {
        GameOver, 
        GameStart,
    }

    public interface ICallback {
        
    }

    public class Messenger : Singleton<Messenger>
    {
        public Dictionary<EGameEvent, Delegate> mEventTable = new Dictionary<EGameEvent, Delegate>();

        public bool IsCanOnlistener(EGameEvent eGameEvent, Delegate handler)
        {
            if (!mEventTable.ContainsKey(eGameEvent))
            {
                mEventTable.Add(eGameEvent, null); 
            }
            Delegate d = mEventTable[eGameEvent];
            if (d != null && d.GetType() != handler.GetType())
            {
                Console.WriteLine("监听回调 和 当前监听类型不符合");
                return false;
            }
            return true;
        }
        //添加监听
        public void AddListener(EGameEvent eGameEvent, Callback Handler)
        {
            if (!IsCanOnlistener(eGameEvent, Handler))
            {
                return;
            }
            mEventTable[eGameEvent] = (Callback)mEventTable[eGameEvent] + Handler;
        }
        public void AddListener<T>(EGameEvent eGameEvent, Callback<T> Handler)
        {
            if (!IsCanOnlistener(eGameEvent, Handler))
            {
                return;
            }
            mEventTable[eGameEvent] = (Callback<T>)mEventTable[eGameEvent] + Handler;
        }
        

        public void RemoveListener() { }

        public void Broadcast(EGameEvent eGameEvent)
        {
            if (!mEventTable.ContainsKey(eGameEvent))
            {
                return;
            }
            Delegate del;
            if (mEventTable.TryGetValue(eGameEvent,out del))
            {
                Callback callback = del as Callback;
                if (callback!=null)
                {
                    callback();
                } 
                else
                {
                    Console.WriteLine("广播" + eGameEvent.GetType().Name);
                }
            }
        }
        public void Broadcast<T>(EGameEvent eGameEvent,T agr0)
        {
            if (!mEventTable.ContainsKey(eGameEvent))
            {
                return;
            }
            Delegate del;
            if (mEventTable.TryGetValue(eGameEvent, out del))
            {
                Callback<T> callback = del as Callback<T>;
                if (callback != null)
                {
                    callback(agr0);
                }
                else
                {
                    Console.WriteLine("广播" + eGameEvent.GetType().Name);
                }
            }
        }

    }
}
