﻿using Spackle;
using System;

namespace DependenciesDemystified.Core
{
	public sealed class LizAsParent
		: IParent
	{
		private readonly SecureRandom random = new SecureRandom();

		public decimal ProduceFunds()
		{
			if (this.random.Next(0, 10) == 0)
			{
				return 100M;
			}
			else
			{
				return 0M;
			}
		}
	}
}
