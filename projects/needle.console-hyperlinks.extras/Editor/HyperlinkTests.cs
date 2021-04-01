﻿using UnityEditor;
using UnityEngine;

namespace Needle
{
	internal static class HyperlinkTests
	{
		[MenuItem("Test/PrintHyperlinks")]
		private static void Print()
		{
			Debug.Log("Open Needle Website".LinkTo("https://www.needle.tools"));
			Debug.Log("<a href=\"http://www.google.com\">My Link</a>");
			Debug.Log("Open external file".LinkTo("../SomeExternalFile.md"));
		}
	}
}