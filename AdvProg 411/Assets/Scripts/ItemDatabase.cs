﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
	public List<Item> itemList = new List<Item>();
	public List<Texture2D> icons = new List<Texture2D>();
	void Start()
	{
		//string itemName;
		//int itemID;
		//string itemDesc;
		//int itemPower;
		//int itemSpeed;
		//ItemType itemType;
		//DropType dropType;
		//Texture2D itemIcon;
		//Item(string name, int id, string desc, int power, int speed, ItemType type, DropType drop)
		//0 - 9 - weapons //
		itemList.Add (new Item ("Sword1", 0, "WOW!", 1, 1, Item.ItemType.Weapon, Item.DropType.Use));
		itemList.Add (new Item ("Sword2", 1, "Cool!", 1, 1, Item.ItemType.Weapon, Item.DropType.Use));
		itemList.Add (new Item ("Sword3", 2, "Nice!", 1, 1, Item.ItemType.Weapon, Item.DropType.Use));
		//10 ~ 19 outfit //
		itemList.Add(new Item("Headhunter", 3, "Potion to regain some health", 15, 0, Item.ItemType.Outfit, Item.DropType.Use));
		//20 ~ 29 consumables //
		itemList.Add(new Item("Sunshine Herb", 29, "Left-over radiation of vital energy. Use to regain some health", 15, 0, Item.ItemType.Consumable, Item.DropType.ConsumeOnUse));
		//30 ~ 39 consumables //
		itemList.Add(new Item("Shadow Moss", 30, "Left-over radiation of energy. Pick to regain small health", 5, 0, Item.ItemType.Consumable, Item.DropType.ConsumeOnPick));

		icons.Add (Resources.Load<Texture2D> ("Textures/Sword1"));
	}
}
