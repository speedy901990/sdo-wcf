﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sdo_wcf
{
	public class VectorClock
	{
		private string logFile = "defaultLog";
		private List<KeyValuePair<DateTime, string>> versions;
		private static int MAX_NUMBER_OF_VERSIONS = Int16.MaxValue;
		private long timestamp;

		public enum VectorComparison { Smaller = -1, Equal = 0, Greater = 1, Simultaneous = 999 }

		public VectorClock(string filename)
		{
			logFile = filename;
			versions = new List<KeyValuePair<DateTime, string>>();

		}

		public void logToFile(string message)
		{
			FileStream file = new FileStream(logFile, FileMode.Append, FileAccess.Write);
			StreamWriter sw = new StreamWriter(file);
			sw.Write(message + "\n");
			sw.Close();
			file.Close();
		}

		public void incrementVersion(string details)
		{
			if (versions.Count < MAX_NUMBER_OF_VERSIONS)
			{
				this.timestamp = DateTime.Now.ToBinary();
				KeyValuePair<DateTime, string> newEntry = new KeyValuePair<DateTime, string>(DateTime.Now, details);
				versions.Add(newEntry);
				logToFile(versionToString(versions.Count - 1));
			}
			else
			{
				string errorMsg = "Date: " + DateTime.Now.ToString() + " \n:-: ERR: Cannot log version.";
				logToFile(errorMsg);
			}
		}

		public long getTimestamp()
		{
			return this.timestamp;
		}

		private string versionToString(int index)
		{
			return "Date: " + versions.ElementAt(index).Key.ToString() + " \nAction: " + versions.ElementAt(index).Value.ToString();
		}

		public string getOrderedValues()
		{
			string values = "";
			foreach (var x in versions) 
			{
				values += x.Value.ToString() + " :_: ";
			}
			return values;
		}

		public VectorClock clone()
		{
			return (VectorClock)this.clone();
		}

		public static VectorClock max(VectorClock vcOne, VectorClock vcTwo)
		{
			VectorClock newClock = new VectorClock("default");
			foreach (var x in vcOne.versions)
			{
				newClock.versions.Add(x);
			}

			foreach (var x in vcTwo.versions) 
			{
				if (!newClock.versions.Contains(x))
				{
					newClock.versions.Add(x);
				}
			}

			return newClock;
		}

		public static VectorComparison compare(VectorClock vcOne, VectorClock vcTwo)
		{

			// Initially we assume it is all possible things.
			bool equal	 = true;
			bool greater = true;
			bool smaller = true;

			// Go over all elements in Clock one.
			foreach (var x in vcOne.versions)
			{
				// Compare if also present in clock two.
				if (vcTwo.versions.Contains(x))
				{
					// If there is a difference, it can never be equal.
					// Greater / smaller depends on the difference.
					if (vcOne.getTimestamp() < vcTwo.getTimestamp())
					{
						equal	 = false;
						greater = false;
					}   
					if (vcOne.getTimestamp() > vcTwo.getTimestamp())
					{
						equal	 = false;
						smaller = false;
					}
				}
				// Else assume zero (default value is 0).
				else if (vcOne.getTimestamp() != 0)
				{
					equal	 = false;
					smaller = false;
				}
			}

			// Go over all elements in Clock two.
			foreach (var x in vcTwo.versions)
			{
				// Only elements we have not found in One still need to be checked.
				if (vcOne.getTimestamp() !=0 && vcTwo.getTimestamp() != 0)
				{
					equal	 = false;
					greater = false;
				}
			}

			// Return based on determined information.
			if (equal)
			{
				return VectorComparison.Equal;
			}
			else if (greater && !smaller)
			{
				return VectorComparison.Greater;
			}
			else if (smaller && !greater)
			{
				return VectorComparison.Smaller;
			}
			else
			{
				return VectorComparison.Simultaneous;
			}
		}
	}
}
