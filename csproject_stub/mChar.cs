using System;
using System.IO;
using System.Collections.Generic;

namespace IntroCS
{

	/// A "Place" represents one location in the scenery of the game.  It is 
	/// connected to other places via exits.  For each existing exit, the place 
	/// stores a reference to the neighboring place.
	/// Derived from work of  Michael Kolling and David J. Barnes
	public class mChar
	{
		private string name; //{ get; set; }
		private int curHP; //{ get; set; }
		private int maxHP; // { get; set; }
		private int[][] weapon = new int[3][] 
		{
			new int[3], 
			new int[3],
			new int[4]
		};

		public mChar(string name, int maxHP)
		{
			this.name = name;
			this.maxHP = maxHP;
			this.curHP = maxHP;		
		}

		public void unlockItem(string iName)
		{
			if (iName == "sword") {
				weapon [0] [0] = 1;
			} else if (iName == "shield") {
				weapon [0] [1] = 1;
			} else if (iName == "key1") {
				weapon [0] [2] = 1;
			} else if (iName == "bow") {
				weapon [1] [0] = 1;
			} else if (iName == "fArrow") {
				weapon [1] [1] = 1;
			} else if (iName == "key2") {
				weapon [1] [2] = 1;
			} else if (iName == "staff") {
				weapon [2] [0] = 1;
			} else if (iName == "mFire") {
				weapon [2] [1] = 1;
			} else if (iName == "mIce") {
				weapon [2] [2] = 1;
			} else if (iName == "key3") {
				weapon [2] [3] = 1;
			}
			//for testing purposes 
			else {
				Console.WriteLine ("Something has gone wrong [mChar, unlockItem]");
			}
		}

		public bool haveAllKeys()
		{
			if (weapon [0] [2] + weapon [1] [2] + weapon [2] [3] == 3) 
			{
				return true;
			} 
			else if (weapon [0] [02] + weapon [1] [2] + weapon [2] [3] > 3) 
			{
				Console.WriteLine ("Something has gone wrong [mChar, haveAllKeys]");
				return false;
			}
			else
			{
				return false;
			}
		}

		public void die()
		{
			curHP = 0;
		}

		public int getHP()
		{
			return this.curHP;
		}

		public void deltaHP(int delta)
		{
		}



	}
}
