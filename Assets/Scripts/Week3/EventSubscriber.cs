﻿using UnityEngine;
using SonicBloom.Koreo;

namespace Week3
{
	public class EventSubscriber : MonoBehaviour
	{

		// Start is called before the first frame update
		void Start()
		{
			Koreographer.Instance.RegisterForEvents("TestEventID", FireKeyNote);
		}

		public void OnGameStart()
		{

		}
		private void FireKeyNote(KoreographyEvent koreoEvent)
		{

		}
	}
}

