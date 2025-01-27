﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KERBALISM
{
	public interface IConnectionInfo
	{
		bool HasActiveAntenna { get; }

		bool Linked { get; }

		double Ec { get; }

		double EcIdle { get; }

		double DataRate { get; }

		double Strength { get; }
	}
}
