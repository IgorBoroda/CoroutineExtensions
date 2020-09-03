using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SimpleMan.Extensions
{
    public static class ComponentExtension
    {
        #region DELAY
        public static Coroutine Delay(this MonoBehaviour _component, float _time, Action _callback)
        {
            return _component.StartCoroutine(DelayCounter(_time, _callback));
        }


        public static IEnumerator DelayCounter(float _time, Action _callback)
        {
            yield return new WaitForSeconds(_time);
            _callback?.Invoke();
        }





        public static Coroutine Delay<T>(this MonoBehaviour _component, float _time, Action<T> _callback, T _callbackArgument)
        {
            return _component.StartCoroutine(DelayCounter(_time, _callback, _callbackArgument));
        }


        public static IEnumerator DelayCounter<T>(float _time, Action<T> _callback, T _callBackArgument)
        {
            yield return new WaitForSeconds(_time);
            _callback?.Invoke(_callBackArgument);
        }
        #endregion



        #region WAIT UNTIL
        public static Coroutine WaitUntil(this MonoBehaviour _component, Func<bool> _condition, Action _callback, float _delay = 0)
        {
            return _component.StartCoroutine(WaitUntilCounter(_condition, _callback, _delay));
        }


        public static IEnumerator WaitUntilCounter(Func<bool> _condition, Action _callback, float _delay = 0)
        {
            while (_condition() == false)
            {
                if (_delay <= 0)
                    yield return null;

                else
                    yield return new WaitForSeconds(_delay);
            }

            _callback?.Invoke();
        }







        public static Coroutine WaitUntil<T>(this MonoBehaviour _component, Func<bool> _condition, Action<T> _callback, T _callbackArgument, float _delay = 0)
        {
            return _component.StartCoroutine(WaitUntilCounter(_condition, _callback, _callbackArgument, _delay));
        }


        public static IEnumerator WaitUntilCounter<T>(Func<bool> _condition, Action<T> _callback, T _callbackArgument, float _delay = 0)
        {
            while (_condition() == false)
            {
                if (_delay <= 0)
                    yield return null;

                else
                    yield return new WaitForSeconds(_delay);
            }

            _callback?.Invoke(_callbackArgument);
        }
        #endregion



        #region REPEAT UNTIL
        public static Coroutine RepeatUntil(this MonoBehaviour _component, Func<bool> _condition, Action _repeatAction, Action _callback, float _delay = 0)
        {
            return _component.StartCoroutine(RepeatUntilCounter(_condition, _repeatAction, _callback, _delay));
        }


        public static IEnumerator RepeatUntilCounter(Func<bool> _condition, Action _repeatAction, Action _callback, float _delay = 0)
        {
            while (_condition() == false)
            {
                _repeatAction?.Invoke();


                if (_delay <= 0)
                    yield return null;

                else
                    yield return new WaitForSeconds(_delay);
            }

            _callback?.Invoke();
        }





        public static Coroutine RepeatUntil<T>(this MonoBehaviour _component, Func<bool> _condition, Action _repeatAction, Action<T> _callback, T _callbackArgument, float _delay = 0)
        {
            return _component.StartCoroutine(RepeatUntilCounter(_condition, _repeatAction, _callback, _callbackArgument, _delay));
        }


        public static IEnumerator RepeatUntilCounter<T>(Func<bool> _condition, Action _repeatAction, Action<T> _callback, T _callbackArgument, float _delay = 0)
        {
            while (_condition() == false)
            {
                _repeatAction?.Invoke();


                if (_delay <= 0)
                    yield return null;

                else
                    yield return new WaitForSeconds(_delay);
            }

            _callback?.Invoke(_callbackArgument);
        }



        public static Coroutine RepeatUntil<U>(this MonoBehaviour _component, Func<bool> _condition, Action<U> _repeatAction, U _repeatActionArgument, Action _callback, float _delay = 0)
        {
            return _component.StartCoroutine(RepeatUntilCounter(_condition, _repeatAction, _repeatActionArgument, _callback, _delay));
        }


        public static IEnumerator RepeatUntilCounter<U>(Func<bool> _condition, Action<U> _repeatAction, U _repeatActionArgument, Action _callback, float _delay = 0)
        {
            while (_condition() == false)
            {
                _repeatAction.Invoke(_repeatActionArgument);


                if (_delay <= 0)
                    yield return null;

                else
                    yield return new WaitForSeconds(_delay);
            }

            _callback?.Invoke();
        }




        public static Coroutine RepeatUntil<T, U>(this MonoBehaviour _component, Func<bool> _condition, Action<U> _repeatAction, U _repeatActionArgument, Action<T> _callback, T _callbackArgument, float _delay = 0)
        {
            return _component.StartCoroutine(RepeatUntilCounter(_condition, _repeatAction, _repeatActionArgument, _callback, _callbackArgument, _delay));
        }


        public static IEnumerator RepeatUntilCounter<T, U>(Func<bool> _condition, Action<U> _repeatAction, U _repeatActionArgument, Action<T> _callback, T _callbackArgument, float _delay = 0)
        {
            while (_condition() == false)
            {
                _repeatAction?.Invoke(_repeatActionArgument);


                if (_delay <= 0)
                    yield return null;

                else
                    yield return new WaitForSeconds(_delay);
            }

            _callback?.Invoke(_callbackArgument);
        }
        #endregion
    }
}
