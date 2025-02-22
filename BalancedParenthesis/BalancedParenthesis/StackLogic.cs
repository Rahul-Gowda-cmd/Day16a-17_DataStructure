﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedParenthesis
{
     public class StackLogic_cs
    {
		private int maxSize;
		private long[] stackArray;
		private int top;

		//for size  
		public StackLogic_cs(int s)
		{
			maxSize = s;
			stackArray = new long[maxSize];
			top = -1;
		}

		//for push   
		public void push(long j)
		{
			stackArray[++top] = j;
		}

		//for pop   
		public long pop()
		{
			return stackArray[top--];
		}

		//for peek   
		public long peek()
		{
			return stackArray[top];
		}

		//to check whether stack is empty	   
		public bool isEmpty()
		{
			return (top == -1);
		}

		//to check whether stack is full	   
		public bool isFull()
		{
			return (top == maxSize - 1);
		}
	}
}
