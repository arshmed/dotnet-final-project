﻿using System;
namespace Core.Utilities.Results
{
	// temel voidler icin baslangic
	public interface IResult
	{
		bool Success { get; }
		string Message { get; }
	}
}

