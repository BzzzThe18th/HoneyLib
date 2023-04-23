using System;

namespace HoneyLib.Events
{

	/*
	MIT License

	Copyright (c) 2021 legoandmars

	Permission is hereby granted, free of charge, to any person obtaining a copy
	of this software and associated documentation files (the "Software"), to deal
	in the Software without restriction, including without limitation the rights
	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
	copies of the Software, and to permit persons to whom the Software is
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in all
	copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
	SOFTWARE.
	*/

	//the following is from https://github.com/Graicc/Utilla/tree/master

	public static class EventHandlerExtensions
	{
		public static void SafeInvoke(this EventHandler handler, object sender, EventArgs e)
		{
			foreach (EventHandler handler2 in handler?.GetInvocationList())
			{
				try
				{
					handler2?.Invoke(sender, e);
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.LogError(ex);
				}
			}
		}

		public static void SafeInvoke<T>(this EventHandler<T> handler, object sender, T e) where T : EventArgs
		{
			foreach (EventHandler<T> handler2 in handler?.GetInvocationList())
			{
				try
				{
					handler2?.Invoke(sender, e);
				}
				catch (Exception ex)
				{
					UnityEngine.Debug.LogError(ex);
				}
			}
		}
	}
}
